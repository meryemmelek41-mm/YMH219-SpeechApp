namespace SpeechApp
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabTTS = new System.Windows.Forms.TabPage();
            this.tabSTT = new System.Windows.Forms.TabPage();

            // TTS Tab controls
            this.lblTTSTitle = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.lblVoice = new System.Windows.Forms.Label();
            this.cmbVoice = new System.Windows.Forms.ComboBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.trkRate = new System.Windows.Forms.TrackBar();
            this.lblRateVal = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.lblVolumeVal = new System.Windows.Forms.Label();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTTSStatus = new System.Windows.Forms.Label();

            // STT Tab controls
            this.lblSTTTitle = new System.Windows.Forms.Label();
            this.btnStartListen = new System.Windows.Forms.Button();
            this.btnStopListen = new System.Windows.Forms.Button();
            this.lblLiveText = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnSaveHistory = new System.Windows.Forms.Button();
            this.lblSTTStatus = new System.Windows.Forms.Label();
            this.lblHistoryTitle = new System.Windows.Forms.Label();

            // Status bar
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();

            // ========== TabControl ==========
            this.tabControl.SuspendLayout();
            this.SuspendLayout();

            this.tabControl.Controls.Add(this.tabTTS);
            this.tabControl.Controls.Add(this.tabSTT);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 500);
            this.tabControl.TabIndex = 0;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);

            // ========== TTS Tab ==========
            this.tabTTS.Text = "🔊 Metin → Ses (TTS)";
            this.tabTTS.BackColor = System.Drawing.Color.White;
            this.tabTTS.Padding = new System.Windows.Forms.Padding(10);

            // TTS Title
            this.lblTTSTitle.Text = "Metni Seslendir";
            this.lblTTSTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTTSTitle.ForeColor = System.Drawing.Color.FromArgb(63, 81, 181);
            this.lblTTSTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTTSTitle.Size = new System.Drawing.Size(300, 30);

            // Text Input
            this.txtInput.Location = new System.Drawing.Point(15, 55);
            this.txtInput.Size = new System.Drawing.Size(720, 120);
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtInput.Text = "Merhaba! Bu bir metin-ses dönüştürme uygulamasıdır. Buraya istediğiniz metni yazın.";
            this.txtInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;

            // Voice selector
            this.lblVoice.Text = "Ses:";
            this.lblVoice.Location = new System.Drawing.Point(15, 190);
            this.lblVoice.Size = new System.Drawing.Size(50, 25);
            this.lblVoice.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.cmbVoice.Location = new System.Drawing.Point(70, 187);
            this.cmbVoice.Size = new System.Drawing.Size(300, 28);
            this.cmbVoice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Rate
            this.lblRate.Text = "Hız:";
            this.lblRate.Location = new System.Drawing.Point(15, 230);
            this.lblRate.Size = new System.Drawing.Size(50, 25);
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.trkRate.Location = new System.Drawing.Point(70, 225);
            this.trkRate.Size = new System.Drawing.Size(300, 45);
            this.trkRate.Minimum = -10;
            this.trkRate.Maximum = 10;
            this.trkRate.Value = 0;
            this.trkRate.TickFrequency = 2;

            this.lblRateVal.Text = "0";
            this.lblRateVal.Location = new System.Drawing.Point(380, 230);
            this.lblRateVal.Size = new System.Drawing.Size(40, 25);
            this.lblRateVal.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Volume
            this.lblVolume.Text = "Ses:";
            this.lblVolume.Location = new System.Drawing.Point(15, 275);
            this.lblVolume.Size = new System.Drawing.Size(50, 25);
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.trkVolume.Location = new System.Drawing.Point(70, 270);
            this.trkVolume.Size = new System.Drawing.Size(300, 45);
            this.trkVolume.Minimum = 0;
            this.trkVolume.Maximum = 100;
            this.trkVolume.Value = 80;
            this.trkVolume.TickFrequency = 10;

            this.lblVolumeVal.Text = "80";
            this.lblVolumeVal.Location = new System.Drawing.Point(380, 275);
            this.lblVolumeVal.Size = new System.Drawing.Size(40, 25);
            this.lblVolumeVal.Font = new System.Drawing.Font("Segoe UI", 10F);

            // Buttons TTS
            this.btnSpeak.Text = "▶ Seslendir";
            this.btnSpeak.Location = new System.Drawing.Point(15, 330);
            this.btnSpeak.Size = new System.Drawing.Size(140, 42);
            this.btnSpeak.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSpeak.BackColor = System.Drawing.Color.FromArgb(63, 81, 181);
            this.btnSpeak.ForeColor = System.Drawing.Color.White;
            this.btnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeak.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnPause.Text = "⏸ Duraklat";
            this.btnPause.Location = new System.Drawing.Point(170, 330);
            this.btnPause.Size = new System.Drawing.Size(140, 42);
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Enabled = false;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnStop.Text = "⏹ Durdur";
            this.btnStop.Location = new System.Drawing.Point(325, 330);
            this.btnStop.Size = new System.Drawing.Size(140, 42);
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Enabled = false;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblTTSStatus.Text = "⬤ Hazır";
            this.lblTTSStatus.Location = new System.Drawing.Point(15, 390);
            this.lblTTSStatus.Size = new System.Drawing.Size(400, 30);
            this.lblTTSStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTTSStatus.ForeColor = System.Drawing.Color.Green;

            this.tabTTS.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTTSTitle, this.txtInput,
                this.lblVoice, this.cmbVoice,
                this.lblRate, this.trkRate, this.lblRateVal,
                this.lblVolume, this.trkVolume, this.lblVolumeVal,
                this.btnSpeak, this.btnPause, this.btnStop,
                this.lblTTSStatus
            });

            // ========== STT Tab ==========
            this.tabSTT.Text = "🎤 Ses → Metin (STT)";
            this.tabSTT.BackColor = System.Drawing.Color.White;
            this.tabSTT.Padding = new System.Windows.Forms.Padding(10);

            this.lblSTTTitle.Text = "Konuşmayı Tanı";
            this.lblSTTTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSTTTitle.ForeColor = System.Drawing.Color.FromArgb(63, 81, 181);
            this.lblSTTTitle.Location = new System.Drawing.Point(15, 15);
            this.lblSTTTitle.Size = new System.Drawing.Size(300, 30);

            this.btnStartListen.Text = "🎤 Dinlemeye Başla";
            this.btnStartListen.Location = new System.Drawing.Point(15, 60);
            this.btnStartListen.Size = new System.Drawing.Size(200, 45);
            this.btnStartListen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnStartListen.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnStartListen.ForeColor = System.Drawing.Color.White;
            this.btnStartListen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartListen.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnStopListen.Text = "⏹ Durdur";
            this.btnStopListen.Location = new System.Drawing.Point(230, 60);
            this.btnStopListen.Size = new System.Drawing.Size(160, 45);
            this.btnStopListen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnStopListen.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.btnStopListen.ForeColor = System.Drawing.Color.White;
            this.btnStopListen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopListen.Enabled = false;
            this.btnStopListen.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblLiveText.Text = "🔈 Algılanan: —";
            this.lblLiveText.Location = new System.Drawing.Point(15, 125);
            this.lblLiveText.Size = new System.Drawing.Size(720, 30);
            this.lblLiveText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblLiveText.ForeColor = System.Drawing.Color.Gray;

            this.lblHistoryTitle.Text = "Tanıma Geçmişi:";
            this.lblHistoryTitle.Location = new System.Drawing.Point(15, 165);
            this.lblHistoryTitle.Size = new System.Drawing.Size(200, 25);
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.lstHistory.Location = new System.Drawing.Point(15, 195);
            this.lstHistory.Size = new System.Drawing.Size(720, 220);
            this.lstHistory.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstHistory.HorizontalScrollbar = true;

            this.btnSaveHistory.Text = "💾 Dosyaya Kaydet";
            this.btnSaveHistory.Location = new System.Drawing.Point(15, 425);
            this.btnSaveHistory.Size = new System.Drawing.Size(200, 40);
            this.btnSaveHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSaveHistory.BackColor = System.Drawing.Color.FromArgb(63, 81, 181);
            this.btnSaveHistory.ForeColor = System.Drawing.Color.White;
            this.btnSaveHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveHistory.Cursor = System.Windows.Forms.Cursors.Hand;

            this.lblSTTStatus.Text = "⬤ Hazır";
            this.lblSTTStatus.Location = new System.Drawing.Point(230, 432);
            this.lblSTTStatus.Size = new System.Drawing.Size(400, 25);
            this.lblSTTStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSTTStatus.ForeColor = System.Drawing.Color.Green;

            this.tabSTT.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSTTTitle,
                this.btnStartListen, this.btnStopListen,
                this.lblLiveText,
                this.lblHistoryTitle, this.lstHistory,
                this.btnSaveHistory, this.lblSTTStatus
            });

            // ========== Status Panel ==========
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(63, 81, 181);
            this.pnlStatus.Location = new System.Drawing.Point(0, 530);
            this.pnlStatus.Size = new System.Drawing.Size(800, 30);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;

            this.lblStatus.Text = "  YMH219 SpeechApp - Meryem Melek Şimşek | 250541017";
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(0, 5);
            this.lblStatus.Size = new System.Drawing.Size(600, 20);
            this.pnlStatus.Controls.Add(this.lblStatus);

            // ========== Form ==========
            this.ClientSize = new System.Drawing.Size(784, 560);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlStatus);
            this.Name = "FormMain";
            this.Text = "YMH219 - Speech App | Meryem Melek Şimşek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MinimumSize = new System.Drawing.Size(800, 600);

            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTTS;
        private System.Windows.Forms.TabPage tabSTT;

        // TTS Controls
        private System.Windows.Forms.Label lblTTSTitle;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label lblVoice;
        private System.Windows.Forms.ComboBox cmbVoice;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TrackBar trkRate;
        private System.Windows.Forms.Label lblRateVal;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.Label lblVolumeVal;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTTSStatus;

        // STT Controls
        private System.Windows.Forms.Label lblSTTTitle;
        private System.Windows.Forms.Button btnStartListen;
        private System.Windows.Forms.Button btnStopListen;
        private System.Windows.Forms.Label lblLiveText;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnSaveHistory;
        private System.Windows.Forms.Label lblSTTStatus;

        // Status
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}
