using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;

namespace SpeechApp
{
    public enum SynthesisState
    {
        Ready,
        Speaking,
        Paused
    }

    /// <summary>
    /// Metinden Sese (Text-to-Speech) işlemlerini yöneten servis sınıfı.
    /// System.Speech.Synthesis altyapısını nesne tabanlı olarak sarmalar.
    /// </summary>
    public class SpeechSynthesisService : IDisposable
    {
        private SpeechSynthesizer? _synthesizer;

        public SynthesisState State { get; private set; } = SynthesisState.Ready;
        public int Rate { get; set; } = 0;        // -10 ile +10 arası hız
        public int Volume { get; set; } = 100;    // 0 ile 100 arası ses seviyesi
        public string SelectedVoice { get; private set; } = string.Empty;

        public event Action<SynthesisState>? OnStateChanged;
        public event Action<string>? OnSpeakProgress;
        public event Action<string>? OnError;

        public SpeechSynthesisService()
        {
            InitializeSynthesizer();
        }

        private void InitializeSynthesizer()
        {
            try
            {
                _synthesizer = new SpeechSynthesizer();

                _synthesizer.SpeakStarted += (s, e) =>
                {
                    State = SynthesisState.Speaking;
                    OnStateChanged?.Invoke(State);
                };

                _synthesizer.SpeakCompleted += (s, e) =>
                {
                    State = SynthesisState.Ready;
                    OnStateChanged?.Invoke(State);
                };

                _synthesizer.SpeakProgress += (s, e) =>
                {
                    OnSpeakProgress?.Invoke(e.Text);
                };

                // Varsayılan ses
                var voices = GetInstalledVoices();
                if (voices.Count > 0)
                {
                    SelectedVoice = voices[0];
                }
            }
            catch (Exception ex)
            {
                OnError?.Invoke($"Konuşma motoru başlatılamadı: {ex.Message}");
            }
        }

        /// <summary>
        /// Sistemde yüklü olan seslerin isimlerini listeler.
        /// </summary>
        public List<string> GetInstalledVoices()
        {
            try
            {
                if (_synthesizer == null) return new List<string>();

                return _synthesizer.GetInstalledVoices()
                    .Where(v => v.Enabled)
                    .Select(v => v.VoiceInfo.Name)
                    .ToList();
            }
            catch
            {
                return new List<string>();
            }
        }

        /// <summary>
        /// Kullanılacak sesi ayarlar.
        /// </summary>
        public void SelectVoice(string voiceName)
        {
            try
            {
                if (_synthesizer != null && !string.IsNullOrWhiteSpace(voiceName))
                {
                    _synthesizer.SelectVoice(voiceName);
                    SelectedVoice = voiceName;
                }
            }
            catch (Exception ex)
            {
                OnError?.Invoke($"Ses seçimi başarısız: {ex.Message}");
            }
        }

        /// <summary>
        /// Verilen metni asenkron olarak seslendirir.
        /// </summary>
        public void SpeakAsync(string text)
        {
            if (_synthesizer == null || string.IsNullOrWhiteSpace(text)) return;

            try
            {
                // Önceki konuşma varsa durdur
                Stop();

                _synthesizer.Rate = Math.Max(-10, Math.Min(10, Rate));
                _synthesizer.Volume = Math.Max(0, Math.Min(100, Volume));

                _synthesizer.SpeakAsync(text);
                State = SynthesisState.Speaking;
                OnStateChanged?.Invoke(State);
            }
            catch (Exception ex)
            {
                OnError?.Invoke($"Seslendirme hatası: {ex.Message}");
            }
        }

        /// <summary>
        /// Seslendirmeyi duraklatır.
        /// </summary>
        public void Pause()
        {
            if (_synthesizer != null && State == SynthesisState.Speaking)
            {
                try
                {
                    _synthesizer.Pause();
                    State = SynthesisState.Paused;
                    OnStateChanged?.Invoke(State);
                }
                catch (Exception ex)
                {
                    OnError?.Invoke($"Duraklatma hatası: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Duraklatılmış seslendirmeyi devam ettirir.
        /// </summary>
        public void Resume()
        {
            if (_synthesizer != null && State == SynthesisState.Paused)
            {
                try
                {
                    _synthesizer.Resume();
                    State = SynthesisState.Speaking;
                    OnStateChanged?.Invoke(State);
                }
                catch (Exception ex)
                {
                    OnError?.Invoke($"Devam ettirme hatası: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Seslendirmeyi tamamen durdurur.
        /// </summary>
        public void Stop()
        {
            if (_synthesizer != null)
            {
                try
                {
                    _synthesizer.SpeakAsyncCancelAll();
                    State = SynthesisState.Ready;
                    OnStateChanged?.Invoke(State);
                }
                catch { }
            }
        }

        public void Dispose()
        {
            Stop();
            _synthesizer?.Dispose();
            _synthesizer = null;
        }
    }
}
