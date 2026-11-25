namespace SpeechApp
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabTTS = new System.Windows.Forms.TabPage();
            this.pnlTTSContent = new System.Windows.Forms.Panel();
            this.txtTTSInput = new System.Windows.Forms.RichTextBox();
            this.pnlTTSSettings = new System.Windows.Forms.Panel();
            this.lblVolumeValue = new System.Windows.Forms.Label();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblSpeedValue = new System.Windows.Forms.Label();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.cmbVoices = new System.Windows.Forms.ComboBox();
            this.lblVoiceSelect = new System.Windows.Forms.Label();
            this.pnlTTSControls = new System.Windows.Forms.Panel();
            this.btnTTSClear = new System.Windows.Forms.Button();
            this.btnTTSStop = new System.Windows.Forms.Button();
            this.btnTTSPauseResume = new System.Windows.Forms.Button();
            this.btnTTSSpeak = new System.Windows.Forms.Button();
            this.pnlTTSHeader = new System.Windows.Forms.Panel();
            this.lblTTSStatus = new System.Windows.Forms.Label();
            this.lblTTSSubtitle = new System.Windows.Forms.Label();
            this.lblTTSTitle = new System.Windows.Forms.Label();
            this.tabSTT = new System.Windows.Forms.TabPage();
            this.pnlSTTContent = new System.Windows.Forms.Panel();
            this.splitSTT = new System.Windows.Forms.SplitContainer();
            this.lblCurrentRecognized = new System.Windows.Forms.Label();
            this.txtSTTResult = new System.Windows.Forms.RichTextBox();
            this.pnlSTTListHeader = new System.Windows.Forms.Panel();
            this.btnSaveTranscript = new System.Windows.Forms.Button();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.lstRecognitionHistory = new System.Windows.Forms.ListBox();
            this.pnlSTTControls = new System.Windows.Forms.Panel();
            this.btnSTTClear = new System.Windows.Forms.Button();
            this.btnSTTStop = new System.Windows.Forms.Button();
            this.btnSTTStart = new System.Windows.Forms.Button();
            this.pnlSTTHeader = new System.Windows.Forms.Panel();
            this.lblSTTStatus = new System.Windows.Forms.Label();
            this.lblSTTSubtitle = new System.Windows.Forms.Label();
            this.lblSTTTitle = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabTTS.SuspendLayout();
            this.pnlTTSContent.SuspendLayout();
            this.pnlTTSSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            this.pnlTTSControls.SuspendLayout();
            this.pnlTTSHeader.SuspendLayout();
            this.tabSTT.SuspendLayout();
            this.pnlSTTContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSTT)).BeginInit();
            this.splitSTT.Panel1.SuspendLayout();
            this.splitSTT.Panel2.SuspendLayout();
            this.splitSTT.SuspendLayout();
            this.pnlSTTListHeader.SuspendLayout();
            this.pnlSTTControls.SuspendLayout();
            this.pnlSTTHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabTTS);
            this.tabControlMain.Controls.Add(this.tabSTT);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(940, 620);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabTTS
            // 
            this.tabTTS.Controls.Add(this.pnlTTSContent);
            this.tabTTS.Controls.Add(this.pnlTTSSettings);
            this.tabTTS.Controls.Add(this.pnlTTSControls);
            this.tabTTS.Controls.Add(this.pnlTTSHeader);
            this.tabTTS.Location = new System.Drawing.Point(4, 26);
            this.tabTTS.Name = "tabTTS";
            this.tabTTS.Padding = new System.Windows.Forms.Padding(3);
            this.tabTTS.Size = new System.Drawing.Size(932, 590);
            this.tabTTS.TabIndex = 0;
            this.tabTTS.Text = "🔊 Metinden Sese (Text-to-Speech)";
            this.tabTTS.UseVisualStyleBackColor = true;
            // 
            // pnlTTSContent
            // 
            this.pnlTTSContent.Controls.Add(this.txtTTSInput);
            this.pnlTTSContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTTSContent.Location = new System.Drawing.Point(3, 140);
            this.pnlTTSContent.Name = "pnlTTSContent";
            this.pnlTTSContent.Padding = new System.Windows.Forms.Padding(15);
            this.pnlTTSContent.Size = new System.Drawing.Size(926, 360);
            this.pnlTTSContent.TabIndex = 3;
            // 
            // txtTTSInput
            // 
            this.txtTTSInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.txtTTSInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTTSInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTTSInput.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTTSInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.txtTTSInput.Location = new System.Drawing.Point(15, 15);
            this.txtTTSInput.Name = "txtTTSInput";
            this.txtTTSInput.Size = new System.Drawing.Size(896, 330);
            this.txtTTSInput.TabIndex = 0;
            this.txtTTSInput.Text = "Merhaba! Bu uygulama Nesne Tabanlı Programlama (YMH 219) dersi kapsamında gelişt" +
    "irilmiş konuşma sentezleme ve tanıma sistemidir.";
            // 
            // pnlTTSSettings
            // 
            this.pnlTTSSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.pnlTTSSettings.Controls.Add(this.lblVolumeValue);
            this.pnlTTSSettings.Controls.Add(this.trackVolume);
            this.pnlTTSSettings.Controls.Add(this.lblVolume);
            this.pnlTTSSettings.Controls.Add(this.lblSpeedValue);
            this.pnlTTSSettings.Controls.Add(this.trackSpeed);
            this.pnlTTSSettings.Controls.Add(this.lblSpeed);
            this.pnlTTSSettings.Controls.Add(this.cmbVoices);
            this.pnlTTSSettings.Controls.Add(this.lblVoiceSelect);
            this.pnlTTSSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTTSSettings.Location = new System.Drawing.Point(3, 500);
            this.pnlTTSSettings.Name = "pnlTTSSettings";
            this.pnlTTSSettings.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlTTSSettings.Size = new System.Drawing.Size(926, 87);
            this.pnlTTSSettings.TabIndex = 2;
            // 
            // lblVolumeValue
            // 
            this.lblVolumeValue.AutoSize = true;
            this.lblVolumeValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVolumeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblVolumeValue.Location = new System.Drawing.Point(860, 48);
            this.lblVolumeValue.Name = "lblVolumeValue";
            this.lblVolumeValue.Size = new System.Drawing.Size(37, 15);
            this.lblVolumeValue.TabIndex = 7;
            this.lblVolumeValue.Text = "%100";
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(640, 42);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(210, 45);
            this.trackVolume.TabIndex = 6;
            this.trackVolume.TickFrequency = 10;
            this.trackVolume.Value = 100;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblVolume.Location = new System.Drawing.Point(640, 15);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(89, 17);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "Ses Seviyesi:";
            // 
            // lblSpeedValue
            // 
            this.lblSpeedValue.AutoSize = true;
            this.lblSpeedValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblSpeedValue.Location = new System.Drawing.Point(545, 48);
            this.lblSpeedValue.Name = "lblSpeedValue";
            this.lblSpeedValue.Size = new System.Drawing.Size(43, 15);
            this.lblSpeedValue.TabIndex = 4;
            this.lblSpeedValue.Text = "Normal";
            // 
            // trackSpeed
            // 
            this.trackSpeed.Location = new System.Drawing.Point(340, 42);
            this.trackSpeed.Minimum = -10;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(200, 45);
            this.trackSpeed.TabIndex = 3;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSpeed.Location = new System.Drawing.Point(340, 15);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(127, 17);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Okuma Hızı (Rate):";
            // 
            // cmbVoices
            // 
            this.cmbVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoices.FormattingEnabled = true;
            this.cmbVoices.Location = new System.Drawing.Point(15, 42);
            this.cmbVoices.Name = "cmbVoices";
            this.cmbVoices.Size = new System.Drawing.Size(290, 25);
            this.cmbVoices.TabIndex = 1;
            // 
            // lblVoiceSelect
            // 
            this.lblVoiceSelect.AutoSize = true;
            this.lblVoiceSelect.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVoiceSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblVoiceSelect.Location = new System.Drawing.Point(15, 15);
            this.lblVoiceSelect.Name = "lblVoiceSelect";
            this.lblVoiceSelect.Size = new System.Drawing.Size(129, 17);
            this.lblVoiceSelect.TabIndex = 0;
            this.lblVoiceSelect.Text = "Ses Seçimi (Voice):";
            // 
            // pnlTTSControls
            // 
            this.pnlTTSControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlTTSControls.Controls.Add(this.btnTTSClear);
            this.pnlTTSControls.Controls.Add(this.btnTTSStop);
            this.pnlTTSControls.Controls.Add(this.btnTTSPauseResume);
            this.pnlTTSControls.Controls.Add(this.btnTTSSpeak);
            this.pnlTTSControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTTSControls.Location = new System.Drawing.Point(3, 78);
            this.pnlTTSControls.Name = "pnlTTSControls";
            this.pnlTTSControls.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlTTSControls.Size = new System.Drawing.Size(926, 62);
            this.pnlTTSControls.TabIndex = 1;
            // 
            // btnTTSClear
            // 
            this.btnTTSClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnTTSClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTSClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTTSClear.ForeColor = System.Drawing.Color.White;
            this.btnTTSClear.Location = new System.Drawing.Point(545, 12);
            this.btnTTSClear.Name = "btnTTSClear";
            this.btnTTSClear.Size = new System.Drawing.Size(130, 38);
            this.btnTTSClear.TabIndex = 3;
            this.btnTTSClear.Text = "🗑 Temizle";
            this.btnTTSClear.UseVisualStyleBackColor = false;
            // 
            // btnTTSStop
            // 
            this.btnTTSStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnTTSStop.Enabled = false;
            this.btnTTSStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTSStop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTTSStop.ForeColor = System.Drawing.Color.White;
            this.btnTTSStop.Location = new System.Drawing.Point(385, 12);
            this.btnTTSStop.Name = "btnTTSStop";
            this.btnTTSStop.Size = new System.Drawing.Size(140, 38);
            this.btnTTSStop.TabIndex = 2;
            this.btnTTSStop.Text = "⏹ Durdur";
            this.btnTTSStop.UseVisualStyleBackColor = false;
            // 
            // btnTTSPauseResume
            // 
            this.btnTTSPauseResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnTTSPauseResume.Enabled = false;
            this.btnTTSPauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTSPauseResume.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTTSPauseResume.ForeColor = System.Drawing.Color.White;
            this.btnTTSPauseResume.Location = new System.Drawing.Point(195, 12);
            this.btnTTSPauseResume.Name = "btnTTSPauseResume";
            this.btnTTSPauseResume.Size = new System.Drawing.Size(175, 38);
            this.btnTTSPauseResume.TabIndex = 1;
            this.btnTTSPauseResume.Text = "⏸ Duraklat / Devam";
            this.btnTTSPauseResume.UseVisualStyleBackColor = false;
            // 
            // btnTTSSpeak
            // 
            this.btnTTSSpeak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnTTSSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTSSpeak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTTSSpeak.ForeColor = System.Drawing.Color.White;
            this.btnTTSSpeak.Location = new System.Drawing.Point(15, 12);
            this.btnTTSSpeak.Name = "btnTTSSpeak";
            this.btnTTSSpeak.Size = new System.Drawing.Size(165, 38);
            this.btnTTSSpeak.TabIndex = 0;
            this.btnTTSSpeak.Text = "▶ Seslendir (Oku)";
            this.btnTTSSpeak.UseVisualStyleBackColor = false;
            // 
            // pnlTTSHeader
            // 
            this.pnlTTSHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.pnlTTSHeader.Controls.Add(this.lblTTSStatus);
            this.pnlTTSHeader.Controls.Add(this.lblTTSSubtitle);
            this.pnlTTSHeader.Controls.Add(this.lblTTSTitle);
            this.pnlTTSHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTTSHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlTTSHeader.Name = "pnlTTSHeader";
            this.pnlTTSHeader.Padding = new System.Windows.Forms.Padding(15);
            this.pnlTTSHeader.Size = new System.Drawing.Size(926, 75);
            this.pnlTTSHeader.TabIndex = 0;
            // 
            // lblTTSStatus
            // 
            this.lblTTSStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTTSStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTTSStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTTSStatus.ForeColor = System.Drawing.Color.White;
            this.lblTTSStatus.Location = new System.Drawing.Point(716, 18);
            this.lblTTSStatus.Name = "lblTTSStatus";
            this.lblTTSStatus.Size = new System.Drawing.Size(195, 38);
            this.lblTTSStatus.TabIndex = 2;
            this.lblTTSStatus.Text = "⏹ HAZIR";
            this.lblTTSStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTTSSubtitle
            // 
            this.lblTTSSubtitle.AutoSize = true;
            this.lblTTSSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTTSSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(205)))));
            this.lblTTSSubtitle.Location = new System.Drawing.Point(15, 46);
            this.lblTTSSubtitle.Name = "lblTTSSubtitle";
            this.lblTTSSubtitle.Size = new System.Drawing.Size(434, 15);
            this.lblTTSSubtitle.TabIndex = 1;
            this.lblTTSSubtitle.Text = "Yazılan metni seçilen sistem sesi ile seslendirir, hız ve ses seviyesi kontrol ed" +
    "ilebilir.";
            // 
            // lblTTSTitle
            // 
            this.lblTTSTitle.AutoSize = true;
            this.lblTTSTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTTSTitle.ForeColor = System.Drawing.Color.White;
            this.lblTTSTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTTSTitle.Name = "lblTTSTitle";
            this.lblTTSTitle.Size = new System.Drawing.Size(342, 28);
            this.lblTTSTitle.TabIndex = 0;
            this.lblTTSTitle.Text = "🔊 Text-to-Speech (Metinden Sese)";
            // 
            // tabSTT
            // 
            this.tabSTT.Controls.Add(this.pnlSTTContent);
            this.tabSTT.Controls.Add(this.pnlSTTControls);
            this.tabSTT.Controls.Add(this.pnlSTTHeader);
            this.tabSTT.Location = new System.Drawing.Point(4, 26);
            this.tabSTT.Name = "tabSTT";
            this.tabSTT.Padding = new System.Windows.Forms.Padding(3);
            this.tabSTT.Size = new System.Drawing.Size(932, 590);
            this.tabSTT.TabIndex = 1;
            this.tabSTT.Text = "🎤 Sesten Metne (Speech-to-Text)";
            this.tabSTT.UseVisualStyleBackColor = true;
            // 
            // pnlSTTContent
            // 
            this.pnlSTTContent.Controls.Add(this.splitSTT);
            this.pnlSTTContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSTTContent.Location = new System.Drawing.Point(3, 137);
            this.pnlSTTContent.Name = "pnlSTTContent";
            this.pnlSTTContent.Padding = new System.Windows.Forms.Padding(15);
            this.pnlSTTContent.Size = new System.Drawing.Size(926, 450);
            this.pnlSTTContent.TabIndex = 2;
            // 
            // splitSTT
            // 
            this.splitSTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSTT.Location = new System.Drawing.Point(15, 15);
            this.splitSTT.Name = "splitSTT";
            // 
            // splitSTT.Panel1
            // 
            this.splitSTT.Panel1.Controls.Add(this.lblCurrentRecognized);
            this.splitSTT.Panel1.Controls.Add(this.txtSTTResult);
            // 
            // splitSTT.Panel2
            // 
            this.splitSTT.Panel2.Controls.Add(this.pnlSTTListHeader);
            this.splitSTT.Panel2.Controls.Add(this.lstRecognitionHistory);
            this.splitSTT.Size = new System.Drawing.Size(896, 420);
            this.splitSTT.SplitterDistance = 460;
            this.splitSTT.TabIndex = 0;
            // 
            // lblCurrentRecognized
            // 
            this.lblCurrentRecognized.AutoSize = true;
            this.lblCurrentRecognized.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentRecognized.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCurrentRecognized.Location = new System.Drawing.Point(0, 5);
            this.lblCurrentRecognized.Name = "lblCurrentRecognized";
            this.lblCurrentRecognized.Size = new System.Drawing.Size(225, 19);
            this.lblCurrentRecognized.TabIndex = 1;
            this.lblCurrentRecognized.Text = "✍ Canlı Dönüştürülen Metin Alanı:";
            // 
            // txtSTTResult
            // 
            this.txtSTTResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSTTResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.txtSTTResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSTTResult.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSTTResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.txtSTTResult.Location = new System.Drawing.Point(0, 32);
            this.txtSTTResult.Name = "txtSTTResult";
            this.txtSTTResult.Size = new System.Drawing.Size(450, 388);
            this.txtSTTResult.TabIndex = 0;
            this.txtSTTResult.Text = "";
            // 
            // pnlSTTListHeader
            // 
            this.pnlSTTListHeader.Controls.Add(this.btnSaveTranscript);
            this.pnlSTTListHeader.Controls.Add(this.lblHistoryTitle);
            this.pnlSTTListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSTTListHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSTTListHeader.Name = "pnlSTTListHeader";
            this.pnlSTTListHeader.Size = new System.Drawing.Size(432, 32);
            this.pnlSTTListHeader.TabIndex = 2;
            // 
            // btnSaveTranscript
            // 
            this.btnSaveTranscript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTranscript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSaveTranscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTranscript.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveTranscript.ForeColor = System.Drawing.Color.White;
            this.btnSaveTranscript.Location = new System.Drawing.Point(292, 2);
            this.btnSaveTranscript.Name = "btnSaveTranscript";
            this.btnSaveTranscript.Size = new System.Drawing.Size(140, 28);
            this.btnSaveTranscript.TabIndex = 1;
            this.btnSaveTranscript.Text = "💾 Metni Kaydet (.txt)";
            this.btnSaveTranscript.UseVisualStyleBackColor = false;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHistoryTitle.Location = new System.Drawing.Point(0, 5);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(225, 19);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "📜 Tanıma Geçmişi ve Güven Skoru:";
            // 
            // lstRecognitionHistory
            // 
            this.lstRecognitionHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRecognitionHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.lstRecognitionHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRecognitionHistory.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstRecognitionHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lstRecognitionHistory.FormattingEnabled = true;
            this.lstRecognitionHistory.ItemHeight = 15;
            this.lstRecognitionHistory.Location = new System.Drawing.Point(0, 32);
            this.lstRecognitionHistory.Name = "lstRecognitionHistory";
            this.lstRecognitionHistory.Size = new System.Drawing.Size(432, 377);
            this.lstRecognitionHistory.TabIndex = 1;
            // 
            // pnlSTTControls
            // 
            this.pnlSTTControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlSTTControls.Controls.Add(this.btnSTTClear);
            this.pnlSTTControls.Controls.Add(this.btnSTTStop);
            this.pnlSTTControls.Controls.Add(this.btnSTTStart);
            this.pnlSTTControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSTTControls.Location = new System.Drawing.Point(3, 75);
            this.pnlSTTControls.Name = "pnlSTTControls";
            this.pnlSTTControls.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlSTTControls.Size = new System.Drawing.Size(926, 62);
            this.pnlSTTControls.TabIndex = 1;
            // 
            // btnSTTClear
            // 
            this.btnSTTClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnSTTClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTTClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSTTClear.ForeColor = System.Drawing.Color.White;
            this.btnSTTClear.Location = new System.Drawing.Point(385, 12);
            this.btnSTTClear.Name = "btnSTTClear";
            this.btnSTTClear.Size = new System.Drawing.Size(130, 38);
            this.btnSTTClear.TabIndex = 2;
            this.btnSTTClear.Text = "🗑 Temizle";
            this.btnSTTClear.UseVisualStyleBackColor = false;
            // 
            // btnSTTStop
            // 
            this.btnSTTStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSTTStop.Enabled = false;
            this.btnSTTStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTTStop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSTTStop.ForeColor = System.Drawing.Color.White;
            this.btnSTTStop.Location = new System.Drawing.Point(205, 12);
            this.btnSTTStop.Name = "btnSTTStop";
            this.btnSTTStop.Size = new System.Drawing.Size(165, 38);
            this.btnSTTStop.TabIndex = 1;
            this.btnSTTStop.Text = "⏹ Dinlemeyi Durdur";
            this.btnSTTStop.UseVisualStyleBackColor = false;
            // 
            // btnSTTStart
            // 
            this.btnSTTStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSTTStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTTStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSTTStart.ForeColor = System.Drawing.Color.White;
            this.btnSTTStart.Location = new System.Drawing.Point(15, 12);
            this.btnSTTStart.Name = "btnSTTStart";
            this.btnSTTStart.Size = new System.Drawing.Size(175, 38);
            this.btnSTTStart.TabIndex = 0;
            this.btnSTTStart.Text = "🎤 Dinlemeyi Başlat";
            this.btnSTTStart.UseVisualStyleBackColor = false;
            // 
            // pnlSTTHeader
            // 
            this.pnlSTTHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.pnlSTTHeader.Controls.Add(this.lblSTTStatus);
            this.pnlSTTHeader.Controls.Add(this.lblSTTSubtitle);
            this.pnlSTTHeader.Controls.Add(this.lblSTTTitle);
            this.pnlSTTHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSTTHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlSTTHeader.Name = "pnlSTTHeader";
            this.pnlSTTHeader.Padding = new System.Windows.Forms.Padding(15);
            this.pnlSTTHeader.Size = new System.Drawing.Size(926, 72);
            this.pnlSTTHeader.TabIndex = 0;
            // 
            // lblSTTStatus
            // 
            this.lblSTTStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSTTStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSTTStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSTTStatus.ForeColor = System.Drawing.Color.White;
            this.lblSTTStatus.Location = new System.Drawing.Point(696, 17);
            this.lblSTTStatus.Name = "lblSTTStatus";
            this.lblSTTStatus.Size = new System.Drawing.Size(215, 38);
            this.lblSTTStatus.TabIndex = 2;
            this.lblSTTStatus.Text = "⚪ DİNLEME KAPALI";
            this.lblSTTStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSTTSubtitle
            // 
            this.lblSTTSubtitle.AutoSize = true;
            this.lblSTTSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSTTSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(205)))));
            this.lblSTTSubtitle.Location = new System.Drawing.Point(15, 45);
            this.lblSTTSubtitle.Name = "lblSTTSubtitle";
            this.lblSTTSubtitle.Size = new System.Drawing.Size(462, 15);
            this.lblSTTSubtitle.TabIndex = 1;
            this.lblSTTSubtitle.Text = "Mikrofon üzerinden konuşmayı tanıyarak metne dönüştürür ve güven skorunu listeler" +
    ".";
            // 
            // lblSTTTitle
            // 
            this.lblSTTTitle.AutoSize = true;
            this.lblSTTTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSTTTitle.ForeColor = System.Drawing.Color.White;
            this.lblSTTTitle.Location = new System.Drawing.Point(15, 14);
            this.lblSTTTitle.Name = "lblSTTTitle";
            this.lblSTTTitle.Size = new System.Drawing.Size(342, 28);
            this.lblSTTTitle.TabIndex = 0;
            this.lblSTTTitle.Text = "🎤 Speech-to-Text (Sesten Metne)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.tabControlMain);
            this.MinimumSize = new System.Drawing.Size(800, 520);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YMH219 - Speech-to-Text ve Text-to-Speech Uygulaması";
            this.tabControlMain.ResumeLayout(false);
            this.tabTTS.ResumeLayout(false);
            this.pnlTTSContent.ResumeLayout(false);
            this.pnlTTSSettings.ResumeLayout(false);
            this.pnlTTSSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            this.pnlTTSControls.ResumeLayout(false);
            this.pnlTTSHeader.ResumeLayout(false);
            this.pnlTTSHeader.PerformLayout();
            this.tabSTT.ResumeLayout(false);
            this.pnlSTTContent.ResumeLayout(false);
            this.splitSTT.Panel1.ResumeLayout(false);
            this.splitSTT.Panel1.PerformLayout();
            this.splitSTT.Panel2.ResumeLayout(false);
            this.pnlSTTListHeader.ResumeLayout(false);
            this.pnlSTTListHeader.PerformLayout();
            this.pnlSTTControls.ResumeLayout(false);
            this.pnlSTTHeader.ResumeLayout(false);
            this.pnlSTTHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabTTS;
        private System.Windows.Forms.TabPage tabSTT;
        private System.Windows.Forms.Panel pnlTTSHeader;
        private System.Windows.Forms.Label lblTTSTitle;
        private System.Windows.Forms.Label lblTTSSubtitle;
        private System.Windows.Forms.Label lblTTSStatus;
        private System.Windows.Forms.Panel pnlTTSControls;
        private System.Windows.Forms.Button btnTTSSpeak;
        private System.Windows.Forms.Button btnTTSPauseResume;
        private System.Windows.Forms.Button btnTTSStop;
        private System.Windows.Forms.Button btnTTSClear;
        private System.Windows.Forms.Panel pnlTTSSettings;
        private System.Windows.Forms.Label lblVoiceSelect;
        private System.Windows.Forms.ComboBox cmbVoices;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.Label lblSpeedValue;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label lblVolumeValue;
        private System.Windows.Forms.Panel pnlTTSContent;
        private System.Windows.Forms.RichTextBox txtTTSInput;
        private System.Windows.Forms.Panel pnlSTTHeader;
        private System.Windows.Forms.Label lblSTTTitle;
        private System.Windows.Forms.Label lblSTTSubtitle;
        private System.Windows.Forms.Label lblSTTStatus;
        private System.Windows.Forms.Panel pnlSTTControls;
        private System.Windows.Forms.Button btnSTTStart;
        private System.Windows.Forms.Button btnSTTStop;
        private System.Windows.Forms.Button btnSTTClear;
        private System.Windows.Forms.Panel pnlSTTContent;
        private System.Windows.Forms.SplitContainer splitSTT;
        private System.Windows.Forms.Label lblCurrentRecognized;
        private System.Windows.Forms.RichTextBox txtSTTResult;
        private System.Windows.Forms.Panel pnlSTTListHeader;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Button btnSaveTranscript;
        private System.Windows.Forms.ListBox lstRecognitionHistory;
    }
}
