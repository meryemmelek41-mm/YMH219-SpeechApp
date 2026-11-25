using System;
using System.Globalization;
using System.IO;
using System.Speech.Recognition;

namespace SpeechApp
{
    /// <summary>
    /// Sesten Metne (Speech-to-Text) işlemlerini yöneten servis sınıfı.
    /// System.Speech.Recognition altyapısını nesne tabanlı olarak sarmalar.
    /// Mikrofon erişimi ve tanıma olaylarını yönetir.
    /// </summary>
    public class SpeechRecognitionService : IDisposable
    {
        private SpeechRecognitionEngine? _engine;
        public bool IsListening { get; private set; } = false;

        public event Action<RecognitionHistoryModel>? OnSpeechRecognized;
        public event Action<string>? OnSpeechHypothesized; // Anlık tanınan kısmi metin
        public event Action<bool>? OnListeningStateChanged;
        public event Action<string>? OnError;

        public SpeechRecognitionService()
        {
            InitializeEngine();
        }

        private void InitializeEngine()
        {
            try
            {
                // Türkçe veya sistem varsayılan dili
                CultureInfo culture = CultureInfo.CurrentUICulture;
                try
                {
                    _engine = new SpeechRecognitionEngine(culture);
                }
                catch
                {
                    // Türkçe tanıma paketi yoksa sistem varsayılan dili ile dene
                    _engine = new SpeechRecognitionEngine();
                }

                // Serbest konuşma için DictationGrammar yükle
                var dictation = new DictationGrammar();
                _engine.LoadGrammar(dictation);

                _engine.SpeechRecognized += (s, e) =>
                {
                    if (e.Result != null && !string.IsNullOrWhiteSpace(e.Result.Text))
                    {
                        var model = new RecognitionHistoryModel(e.Result.Text, e.Result.Confidence);
                        OnSpeechRecognized?.Invoke(model);
                    }
                };

                _engine.SpeechHypothesized += (s, e) =>
                {
                    if (e.Result != null && !string.IsNullOrWhiteSpace(e.Result.Text))
                    {
                        OnSpeechHypothesized?.Invoke(e.Result.Text);
                    }
                };

                _engine.RecognizeCompleted += (s, e) =>
                {
                    if (IsListening)
                    {
                        // Sürekli tanıma için tekrar başlat
                        try { _engine?.RecognizeAsync(RecognizeMode.Multiple); } catch { }
                    }
                };
            }
            catch (Exception ex)
            {
                OnError?.Invoke($"Konuşma tanıma motoru başlatılamadı: {ex.Message}\n(Lütfen Windows Ayarları'ndan Konuşma Tanıma paketinin yüklü olduğundan emin olun.)");
            }
        }

        /// <summary>
        /// Mikrofondan konuşma dinlemeyi başlatır.
        /// </summary>
        public bool StartListening()
        {
            if (_engine == null)
            {
                OnError?.Invoke("Konuşma tanıma motoru kullanılamıyor! Lütfen mikrofon ve dil paketini kontrol edin.");
                return false;
            }

            if (IsListening) return true;

            try
            {
                // Varsayılan ses giriş aygıtını bağla
                _engine.SetInputToDefaultAudioDevice();
                _engine.RecognizeAsync(RecognizeMode.Multiple);
                IsListening = true;
                OnListeningStateChanged?.Invoke(true);
                return true;
            }
            catch (InvalidOperationException)
            {
                OnError?.Invoke("Mikrofon aygıtı bulunamadı veya başka bir uygulama tarafından kullanılıyor!\nLütfen mikrofon bağlantınızı kontrol edin.");
                IsListening = false;
                OnListeningStateChanged?.Invoke(false);
                return false;
            }
            catch (Exception ex)
            {
                OnError?.Invoke($"Dinleme başlatma hatası: {ex.Message}");
                IsListening = false;
                OnListeningStateChanged?.Invoke(false);
                return false;
            }
        }

        /// <summary>
        /// Konuşma dinlemeyi durdurur.
        /// </summary>
        public void StopListening()
        {
            if (_engine != null && IsListening)
            {
                try
                {
                    _engine.RecognizeAsyncStop();
                }
                catch { }

                IsListening = false;
                OnListeningStateChanged?.Invoke(false);
            }
        }

        public void Dispose()
        {
            StopListening();
            _engine?.Dispose();
            _engine = null;
        }
    }
}
