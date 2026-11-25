using System;
using System.IO;
using System.Windows.Forms;

namespace SpeechApp
{
    public partial class FormMain : Form
    {
        private SpeechSynthesisService _tts;
        private SpeechRecognitionService _stt;
        private bool _isPaused = false;

        public FormMain()
        {
            InitializeComponent();
            InitializeServices();
            WireEvents();
        }

        private void InitializeServices()
        {
            // TTS Service
            _tts = new SpeechSynthesisService();
            _tts.OnStateChanged += (state) => UpdateTTSStatus(state);

            // Load voices into ComboBox
            var voices = _tts.GetInstalledVoices();
            cmbVoice.Items.AddRange(voices.ToArray());
            if (cmbVoice.Items.Count > 0)
                cmbVoice.SelectedIndex = 0;

            // Apply initial rate/volume
            _tts.SetRate(trkRate.Value);
            _tts.SetVolume(trkVolume.Value);

            // STT Service
            _stt = new SpeechRecognitionService();
            _stt.OnSpeechRecognized += (model) =>
            {
                if (InvokeRequired)
                    Invoke(new Action(() => OnSpeechRecognized(model)));
                else
                    OnSpeechRecognized(model);
            };
            _stt.OnSpeechHypothesized += (text) =>
            {
                if (InvokeRequired)
                    Invoke(new Action(() => lblLiveText.Text = $"🔈 Algılanan: {text}"));
                else
                    lblLiveText.Text = $"🔈 Algılanan: {text}";
            };
            _stt.OnError += (msg) =>
            {
                if (InvokeRequired)
                    Invoke(new Action(() => MessageBox.Show(msg, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)));
                else
                    MessageBox.Show(msg, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            _stt.OnStateChanged += (state) =>
            {
                if (InvokeRequired)
                    Invoke(new Action(() => UpdateSTTStatus(state)));
                else
                    UpdateSTTStatus(state);
            };
        }

        private void WireEvents()
        {
            // TTS buttons
            btnSpeak.Click += BtnSpeak_Click;
            btnPause.Click += BtnPause_Click;
            btnStop.Click += BtnStop_Click;

            // Track bars
            trkRate.ValueChanged += (s, e) =>
            {
                lblRateVal.Text = trkRate.Value.ToString();
                _tts.SetRate(trkRate.Value);
            };
            trkVolume.ValueChanged += (s, e) =>
            {
                lblVolumeVal.Text = trkVolume.Value.ToString();
                _tts.SetVolume(trkVolume.Value);
            };

            // Voice selection
            cmbVoice.SelectedIndexChanged += (s, e) =>
            {
                if (cmbVoice.SelectedItem != null)
                    _tts.SetVoice(cmbVoice.SelectedItem.ToString());
            };

            // STT buttons
            btnStartListen.Click += BtnStartListen_Click;
            btnStopListen.Click += BtnStopListen_Click;

            // Save history
            btnSaveHistory.Click += BtnSaveHistory_Click;

            // Form closing
            this.FormClosing += (s, e) =>
            {
                _tts?.Dispose();
                _stt?.Dispose();
            };
        }

        // ==================== TTS ====================

        private void BtnSpeak_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Lütfen seslendirilecek metni girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _isPaused = false;
            _tts.SpeakAsync(txtInput.Text);

            btnSpeak.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnPause.Text = "⏸ Duraklat";
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (_isPaused)
            {
                _tts.Resume();
                _isPaused = false;
                btnPause.Text = "⏸ Duraklat";
                UpdateTTSStatus("Konuşuyor");
            }
            else
            {
                _tts.Pause();
                _isPaused = true;
                btnPause.Text = "▶ Devam Et";
                UpdateTTSStatus("Duraklatıldı");
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            _tts.Stop();
            _isPaused = false;
            btnSpeak.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnPause.Text = "⏸ Duraklat";
            UpdateTTSStatus("Hazır");
        }

        private void UpdateTTSStatus(string state)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateTTSStatus(state)));
                return;
            }

            switch (state)
            {
                case "Konuşuyor":
                    lblTTSStatus.Text = "⬤ Konuşuyor...";
                    lblTTSStatus.ForeColor = System.Drawing.Color.Blue;
                    break;
                case "Duraklatıldı":
                    lblTTSStatus.Text = "⏸ Duraklatıldı";
                    lblTTSStatus.ForeColor = System.Drawing.Color.Orange;
                    break;
                case "Tamamlandı":
                    lblTTSStatus.Text = "✓ Tamamlandı";
                    lblTTSStatus.ForeColor = System.Drawing.Color.Green;
                    btnSpeak.Enabled = true;
                    btnPause.Enabled = false;
                    btnStop.Enabled = false;
                    break;
                default:
                    lblTTSStatus.Text = "⬤ Hazır";
                    lblTTSStatus.ForeColor = System.Drawing.Color.Green;
                    break;
            }
        }

        // ==================== STT ====================

        private void BtnStartListen_Click(object sender, EventArgs e)
        {
            lblLiveText.Text = "🔈 Algılanan: (dinleniyor...)";
            _stt.StartListening();
            btnStartListen.Enabled = false;
            btnStopListen.Enabled = true;
        }

        private void BtnStopListen_Click(object sender, EventArgs e)
        {
            _stt.StopListening();
            lblLiveText.Text = "🔈 Algılanan: —";
            btnStartListen.Enabled = true;
            btnStopListen.Enabled = false;
        }

        private void OnSpeechRecognized(RecognitionHistoryModel model)
        {
            string entry = $"[{model.Timestamp:HH:mm:ss}] ({model.Confidence:P0}) {model.RecognizedText}";
            lstHistory.Items.Insert(0, entry);
        }

        private void UpdateSTTStatus(string state)
        {
            switch (state)
            {
                case "Dinleniyor":
                    lblSTTStatus.Text = "🎤 Dinleniyor...";
                    lblSTTStatus.ForeColor = System.Drawing.Color.Blue;
                    break;
                case "Durduruldu":
                    lblSTTStatus.Text = "⬤ Hazır";
                    lblSTTStatus.ForeColor = System.Drawing.Color.Green;
                    break;
                default:
                    lblSTTStatus.Text = "⬤ Hazır";
                    lblSTTStatus.ForeColor = System.Drawing.Color.Green;
                    break;
            }
        }

        private void BtnSaveHistory_Click(object sender, EventArgs e)
        {
            if (lstHistory.Items.Count == 0)
            {
                MessageBox.Show("Kaydedilecek tanıma geçmişi yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = "Metin Dosyası (*.txt)|*.txt";
                dlg.FileName = $"konusma_tanima_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                dlg.Title = "Tanıma Geçmişini Kaydet";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(dlg.FileName, false, System.Text.Encoding.UTF8))
                    {
                        writer.WriteLine($"YMH219 SpeechApp - Konuşma Tanıma Geçmişi");
                        writer.WriteLine($"Tarih: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
                        writer.WriteLine($"Öğrenci: Meryem Melek Şimşek | 250541017");
                        writer.WriteLine(new string('-', 50));
                        foreach (var item in lstHistory.Items)
                            writer.WriteLine(item.ToString());
                    }
                    MessageBox.Show($"Geçmiş kaydedildi:\n{dlg.FileName}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
