namespace APKYonetici
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrIslem = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblDeger = new System.Windows.Forms.Label();
            this.tmrGiris = new System.Windows.Forms.Timer(this.components);
            this.listLog = new System.Windows.Forms.ListBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrCamp = new System.Windows.Forms.Timer(this.components);
            this.txtVideoLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblVideoCount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPredictionMinute = new System.Windows.Forms.Label();
            this.lblPredictionHour = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProjectError = new System.Windows.Forms.Label();
            this.tmrCampU = new System.Windows.Forms.Timer(this.components);
            this.tmrIslemU = new System.Windows.Forms.Timer(this.components);
            this.tmrTimeU = new System.Windows.Forms.Timer(this.components);
            this.tmrGirisU = new System.Windows.Forms.Timer(this.components);
            this.tmrIslemSub = new System.Windows.Forms.Timer(this.components);
            this.tmrTimeSub = new System.Windows.Forms.Timer(this.components);
            this.tmrGirisSub = new System.Windows.Forms.Timer(this.components);
            this.tmrCampSub = new System.Windows.Forms.Timer(this.components);
            this.txtProjectType = new System.Windows.Forms.TextBox();
            this.listIslemler = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEmiStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrIslem
            // 
            this.tmrIslem.Interval = 1000;
            this.tmrIslem.Tick += new System.EventHandler(this.tmrIslem_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(69, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Baslat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Location = new System.Drawing.Point(19, 22);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(35, 13);
            this.lblDeger.TabIndex = 2;
            this.lblDeger.Text = "label1";
            // 
            // tmrGiris
            // 
            this.tmrGiris.Interval = 1000;
            this.tmrGiris.Tick += new System.EventHandler(this.tmrGiris_Tick);
            // 
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.Location = new System.Drawing.Point(277, 10);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(255, 264);
            this.listLog.TabIndex = 3;
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(83, 146);
            this.txtService.Multiline = true;
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(100, 46);
            this.txtService.TabIndex = 4;
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Location = new System.Drawing.Point(83, 198);
            this.txtDeviceID.Multiline = true;
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(100, 30);
            this.txtDeviceID.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrCamp
            // 
            this.tmrCamp.Interval = 1000;
            this.tmrCamp.Tick += new System.EventHandler(this.tmrCamp_Tick);
            // 
            // txtVideoLink
            // 
            this.txtVideoLink.Location = new System.Drawing.Point(83, 234);
            this.txtVideoLink.Name = "txtVideoLink";
            this.txtVideoLink.Size = new System.Drawing.Size(100, 20);
            this.txtVideoLink.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Süre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DeviceID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Video Link";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Device Name";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(83, 259);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(100, 20);
            this.txtDeviceName.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblVideoCount
            // 
            this.lblVideoCount.AutoSize = true;
            this.lblVideoCount.Location = new System.Drawing.Point(19, 46);
            this.lblVideoCount.Name = "lblVideoCount";
            this.lblVideoCount.Size = new System.Drawing.Size(120, 13);
            this.lblVideoCount.TabIndex = 15;
            this.lblVideoCount.Text = "Tıklanan Video Sayısı = ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(83, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tahmini Dakikada Kazanılan Coin";
            // 
            // lblPredictionMinute
            // 
            this.lblPredictionMinute.AutoSize = true;
            this.lblPredictionMinute.Location = new System.Drawing.Point(199, 71);
            this.lblPredictionMinute.Name = "lblPredictionMinute";
            this.lblPredictionMinute.Size = new System.Drawing.Size(35, 13);
            this.lblPredictionMinute.TabIndex = 18;
            this.lblPredictionMinute.Text = "label7";
            // 
            // lblPredictionHour
            // 
            this.lblPredictionHour.AutoSize = true;
            this.lblPredictionHour.Location = new System.Drawing.Point(199, 97);
            this.lblPredictionHour.Name = "lblPredictionHour";
            this.lblPredictionHour.Size = new System.Drawing.Size(35, 13);
            this.lblPredictionHour.TabIndex = 20;
            this.lblPredictionHour.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tahmini Saatte Kazanılan Coin";
            // 
            // lblProjectError
            // 
            this.lblProjectError.AutoSize = true;
            this.lblProjectError.Location = new System.Drawing.Point(199, 12);
            this.lblProjectError.Name = "lblProjectError";
            this.lblProjectError.Size = new System.Drawing.Size(72, 13);
            this.lblProjectError.TabIndex = 21;
            this.lblProjectError.Text = "Hata Sayısı = ";
            // 
            // tmrCampU
            // 
            this.tmrCampU.Interval = 1000;
            this.tmrCampU.Tick += new System.EventHandler(this.tmrCampU_Tick);
            // 
            // tmrIslemU
            // 
            this.tmrIslemU.Interval = 1000;
            this.tmrIslemU.Tick += new System.EventHandler(this.tmrIslemU_Tick);
            // 
            // tmrTimeU
            // 
            this.tmrTimeU.Interval = 1000;
            this.tmrTimeU.Tick += new System.EventHandler(this.tmrTimeU_Tick);
            // 
            // tmrGirisU
            // 
            this.tmrGirisU.Interval = 1000;
            // 
            // tmrIslemSub
            // 
            this.tmrIslemSub.Interval = 1000;
            this.tmrIslemSub.Tick += new System.EventHandler(this.tmrIslemSub_Tick);
            // 
            // tmrTimeSub
            // 
            this.tmrTimeSub.Interval = 1000;
            this.tmrTimeSub.Tick += new System.EventHandler(this.tmrTimeSub_Tick);
            // 
            // tmrGirisSub
            // 
            this.tmrGirisSub.Interval = 1000;
            // 
            // tmrCampSub
            // 
            this.tmrCampSub.Interval = 1000;
            this.tmrCampSub.Tick += new System.EventHandler(this.tmrCampSub_Tick);
            // 
            // txtProjectType
            // 
            this.txtProjectType.Location = new System.Drawing.Point(556, 284);
            this.txtProjectType.Name = "txtProjectType";
            this.txtProjectType.Size = new System.Drawing.Size(75, 20);
            this.txtProjectType.TabIndex = 22;
            this.txtProjectType.Text = "1";
            // 
            // listIslemler
            // 
            this.listIslemler.FormattingEnabled = true;
            this.listIslemler.Location = new System.Drawing.Point(538, 10);
            this.listIslemler.Name = "listIslemler";
            this.listIslemler.Size = new System.Drawing.Size(148, 264);
            this.listIslemler.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(556, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Bağlan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(648, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Kod çalıştır";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEmiStart
            // 
            this.btnEmiStart.Location = new System.Drawing.Point(189, 118);
            this.btnEmiStart.Name = "btnEmiStart";
            this.btnEmiStart.Size = new System.Drawing.Size(75, 23);
            this.btnEmiStart.TabIndex = 26;
            this.btnEmiStart.Text = "EmiStart";
            this.btnEmiStart.UseVisualStyleBackColor = true;
            this.btnEmiStart.Click += new System.EventHandler(this.btnEmiStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 323);
            this.Controls.Add(this.btnEmiStart);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listIslemler);
            this.Controls.Add(this.txtProjectType);
            this.Controls.Add(this.lblProjectError);
            this.Controls.Add(this.lblPredictionHour);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPredictionMinute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblVideoCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVideoLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDeviceID);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrIslem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.Timer tmrGiris;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrCamp;
        private System.Windows.Forms.TextBox txtVideoLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblVideoCount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPredictionMinute;
        private System.Windows.Forms.Label lblPredictionHour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProjectError;
        private System.Windows.Forms.Timer tmrCampU;
        private System.Windows.Forms.Timer tmrIslemU;
        private System.Windows.Forms.Timer tmrTimeU;
        private System.Windows.Forms.Timer tmrGirisU;
        private System.Windows.Forms.Timer tmrIslemSub;
        private System.Windows.Forms.Timer tmrTimeSub;
        private System.Windows.Forms.Timer tmrGirisSub;
        private System.Windows.Forms.Timer tmrCampSub;
        private System.Windows.Forms.TextBox txtProjectType;
        private System.Windows.Forms.ListBox listIslemler;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEmiStart;
    }
}

