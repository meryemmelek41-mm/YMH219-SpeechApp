using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SpeechApp
{
    /// <summary>
    /// Speech-to-Text ve Text-to-Speech ana kullanıcı arayüzü formu.
    /// Konuşma sentezleme (TTS) ve tanıma (STT) servislerini nesne tabanlı mimari ile yönetir.
    /// </summary>
    public partial class FormMain : Form
    {
        private readonly SpeechSynthesisService _ttsService;
        private readonly SpeechRecognitionService _sttService;

        public FormMain()
        {
            InitializeComponent();

            _ttsService = new SpeechSynthesisService();
            _sttService = new SpeechRecognitionService();

            WireTTSEvents();
            WireSTTEvents();
            WireUIControls();

            PopulateVoices();
        }

        #region Text-to-Speech (TTS) Olayları

        private void WireTTSEvents()
        {
            _ttsService.OnStateChanged += state => SafeInvoke(() =>
            {
                switch (state)
                {
                    case SynthesisState.Speaking:
                        lblTTSStatus.BackColor = Color.FromArgb(46, 204, 113); // Yeşil
                        lblTTSStatus.Text = "🔊 SESLENDİRİLİYOR...";
                        btnTTSSpeak.Enabled = false;
                        btnTTSPauseResume.Enabled = true;
                        btnTTSPauseResume.Text = "⏸ Duraklat";
                        btnTTSStop.Enabled = true;
                        break;

                    case SynthesisState.Paused:
                        lblTTSStatus.BackColor = Color.FromArgb(243, 156, 18); // Turuncu
                        lblTTSStatus.Text = "⏸ DURAKLATILDI";
                        btnTTSSpeak.Enabled = false;
                        btnTTSPauseResume.Enabled = true;
                        btnTTSPauseResume.Text = "▶ Devam Et";
                        btnTTSStop.Enabled = true;
                        break;

                    case SynthesisState.Ready:
                    default:
                        lblTTSStatus.BackColor = Color.FromArgb(108, 117, 125); // Gri
                        lblTTSStatus.Text = "⏹ HAZIR";
                        btnTTSSpeak.Enabled = true;
                        btnTTSPauseResume.Enabled = false;
                        btnTTSPauseResume.Text = "⏸ Duraklat / Devam";
                        btnTTSStop.Enabled = false;
                        break;
                }
            });

            _ttsService.OnError += error => SafeInvoke(() =>
            {
                MessageBox.Show(error, "Seslendirme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            });
        }

        private void PopulateVoices()
        {
            try
            {
                var voices = _ttsService.GetInstalledVoices();
                cmbVoices.Items.Clear();
                foreach (var voice in voices)
                {
                    cmbVoices.Items.Add(voice);
                }

                if (cmbVoices.Items.Count > 0)
                {
                    cmbVoices.SelectedIndex = 0;
                }
            }
            catch { }
        }

        #endregion

        #region Speech-to-Text (STT) Olayları

        private void WireSTTEvents()
        {
            _sttService.OnListeningStateChanged += isListening => SafeInvoke(() =>
            {
                if (isListening)
                {
                    lblSTTStatus.BackColor = Color.FromArgb(231, 76, 60); // Kırmızı
                    lblSTTStatus.Text = "🔴 MİKROFON DİNLİYOR...";
                    btnSTTStart.Enabled = false;
                    btnSTTStop.Enabled = true;
                }
                else
                {
                    lblSTTStatus.BackColor = Color.FromArgb(108, 117, 125); // Gri
                    lblSTTStatus.Text = "⚪ DİNLEME KAPALI";
                    btnSTTStart.Enabled = true;
                    btnSTTStop.Enabled = false;
                }
            });

            _sttService.OnSpeechRecognized += model => SafeInvoke(() =>
            {
                // Metin kutusuna ekle
                if (txtSTTResult.Text.Length > 0)
                    txtSTTResult.AppendText(" ");
                txtSTTResult.AppendText(model.RecognizedText);

                // Geçmiş listesine ekle (Bonus)
                lstRecognitionHistory.Items.Add(model.ToString());
                lstRecognitionHistory.TopIndex = lstRecognitionHistory.Items.Count - 1;
            });

            _sttService.OnError += error => SafeInvoke(() =>
            {
                MessageBox.Show(error, "Mikrofon / Tanıma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
        }

        #endregion

        #region UI Kontrol Olayları

        private void WireUIControls()
        {
            // TTS Butonları
            btnTTSSpeak.Click += (s, e) =>
            {
                var text = txtTTSInput.Text.Trim();
                if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("Lütfen seslendirilecek bir metin yazın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _ttsService.SpeakAsync(text);
            };

            btnTTSPauseResume.Click += (s, e) =>
            {
                if (_ttsService.State == SynthesisState.Speaking)
                {
                    _ttsService.Pause();
                }
                else if (_ttsService.State == SynthesisState.Paused)
                {
                    _ttsService.Resume();
                }
            };

            btnTTSStop.Click += (s, e) => _ttsService.Stop();

            btnTTSClear.Click += (s, e) =>
            {
                txtTTSInput.Clear();
                txtTTSInput.Focus();
            };

            // Hız ve Ses Seviyesi Slider'ları (Bonus)
            trackSpeed.ValueChanged += (s, e) =>
            {
                _ttsService.Rate = trackSpeed.Value;
                lblSpeedValue.Text = trackSpeed.Value == 0 ? "Normal" : (trackSpeed.Value > 0 ? $"+{trackSpeed.Value}" : $"{trackSpeed.Value}");
            };

            trackVolume.ValueChanged += (s, e) =>
            {
                _ttsService.Volume = trackVolume.Value;
                lblVolumeValue.Text = $"%{trackVolume.Value}";
            };

            cmbVoices.SelectedIndexChanged += (s, e) =>
            {
                if (cmbVoices.SelectedItem != null)
                {
                    _ttsService.SelectVoice(cmbVoices.SelectedItem.ToString()!);
                }
            };

            // STT Butonları
            btnSTTStart.Click += (s, e) => _sttService.StartListening();
            btnSTTStop.Click += (s, e) => _sttService.StopListening();

            btnSTTClear.Click += (s, e) =>
            {
                txtSTTResult.Clear();
                lstRecognitionHistory.Items.Clear();
            };

            // Tanıma Metnini Dosyaya Kaydetme (Bonus)
            btnSaveTranscript.Click += BtnSaveTranscript_Click;

            // Form Kapanırken Kaynak Yönetimi
            this.FormClosing += (s, e) =>
            {
                _ttsService.Dispose();
                _sttService.Dispose();
            };
        }

        private void BtnSaveTranscript_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSTTResult.Text) && lstRecognitionHistory.Items.Count == 0)
            {
                MessageBox.Show("Kaydedilecek herhangi bir konuşma metni bulunmuyor!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Konuşma Metnini Kaydet";
                sfd.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
                sfd.FileName = $"KonusmaMetni_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var writer = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            writer.WriteLine("=================================================================");
                            writer.WriteLine("         YMH219 SPEECH-TO-TEXT KONUŞMA METNİ RAPORU             ");
                            writer.WriteLine("=================================================================");
                            writer.WriteLine($"Tarih / Saat : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                            writer.WriteLine("-----------------------------------------------------------------");
                            writer.WriteLine("TAM METİN ÇIKTISI:");
                            writer.WriteLine(txtSTTResult.Text);
                            writer.WriteLine("-----------------------------------------------------------------");
                            writer.WriteLine("ZAMAN DAMGALI TANIMA GEÇMİŞİ:");
                            foreach (var item in lstRecognitionHistory.Items)
                            {
                                writer.WriteLine(item?.ToString());
                            }
                            writer.WriteLine("=================================================================");
                        }
                        MessageBox.Show("Konuşma metni başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Dosya yazma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SafeInvoke(Action action)
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            if (this.InvokeRequired)
            {
                this.BeginInvoke(action);
            }
            else
            {
                action();
            }
        }

        #endregion
    }
}
