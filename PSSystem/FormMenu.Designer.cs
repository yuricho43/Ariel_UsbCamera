namespace PSSystem
{
    partial class FormMenu
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
        private void InitializeComponent()
        {
            btnName = new Button();
            btnWarning = new Button();
            btnCritical = new Button();
            btnSensor = new Button();
            btnRelay = new Button();
            btnWifi = new Button();
            btnVideo = new Button();
            btnData = new Button();
            btnState = new Button();
            btnHome = new Button();
            btnEvent = new Button();
            SuspendLayout();
            // 
            // btnName
            // 
            btnName.FlatStyle = FlatStyle.Flat;
            btnName.Location = new Point(156, 26);
            btnName.Name = "btnName";
            btnName.Size = new Size(168, 37);
            btnName.TabIndex = 0;
            btnName.Text = "1.배전반이름 설정";
            btnName.UseVisualStyleBackColor = true;
            btnName.Click += btnName_Click;
            // 
            // btnWarning
            // 
            btnWarning.FlatStyle = FlatStyle.Flat;
            btnWarning.Location = new Point(156, 82);
            btnWarning.Name = "btnWarning";
            btnWarning.Size = new Size(168, 37);
            btnWarning.TabIndex = 1;
            btnWarning.Text = "2. 1차 경보 설정";
            btnWarning.UseVisualStyleBackColor = true;
            btnWarning.Click += btnWarning_Click;
            // 
            // btnCritical
            // 
            btnCritical.FlatStyle = FlatStyle.Flat;
            btnCritical.Location = new Point(156, 136);
            btnCritical.Name = "btnCritical";
            btnCritical.Size = new Size(168, 37);
            btnCritical.TabIndex = 2;
            btnCritical.Text = "3. 2차 사고 설정";
            btnCritical.UseVisualStyleBackColor = true;
            btnCritical.Click += btnCritical_Click;
            // 
            // btnSensor
            // 
            btnSensor.FlatStyle = FlatStyle.Flat;
            btnSensor.Location = new Point(156, 194);
            btnSensor.Name = "btnSensor";
            btnSensor.Size = new Size(168, 37);
            btnSensor.TabIndex = 3;
            btnSensor.Text = "4. 센서 확장 수 설정";
            btnSensor.UseVisualStyleBackColor = true;
            btnSensor.Click += btnSensor_Click;
            // 
            // btnRelay
            // 
            btnRelay.FlatStyle = FlatStyle.Flat;
            btnRelay.Location = new Point(156, 251);
            btnRelay.Name = "btnRelay";
            btnRelay.Size = new Size(168, 37);
            btnRelay.TabIndex = 4;
            btnRelay.Text = "5. 릴레이 접점 테스트";
            btnRelay.UseVisualStyleBackColor = true;
            btnRelay.Click += btnRelay_Click;
            // 
            // btnWifi
            // 
            btnWifi.FlatStyle = FlatStyle.Flat;
            btnWifi.Location = new Point(458, 194);
            btnWifi.Name = "btnWifi";
            btnWifi.Size = new Size(168, 37);
            btnWifi.TabIndex = 8;
            btnWifi.Text = "9. WIFI ID, PS 설정";
            btnWifi.UseVisualStyleBackColor = true;
            btnWifi.Click += btnWifi_Click;
            // 
            // btnVideo
            // 
            btnVideo.FlatStyle = FlatStyle.Flat;
            btnVideo.Location = new Point(458, 136);
            btnVideo.Name = "btnVideo";
            btnVideo.Size = new Size(168, 37);
            btnVideo.TabIndex = 7;
            btnVideo.Text = "8. 영상 검색";
            btnVideo.UseVisualStyleBackColor = true;
            btnVideo.Click += btnVideo_Click;
            // 
            // btnData
            // 
            btnData.FlatStyle = FlatStyle.Flat;
            btnData.Location = new Point(458, 82);
            btnData.Name = "btnData";
            btnData.Size = new Size(168, 37);
            btnData.TabIndex = 6;
            btnData.Text = "7. 저장 데이타 검색";
            btnData.UseVisualStyleBackColor = true;
            btnData.Click += btnData_Click;
            // 
            // btnState
            // 
            btnState.FlatStyle = FlatStyle.Flat;
            btnState.Location = new Point(458, 26);
            btnState.Name = "btnState";
            btnState.Size = new Size(168, 37);
            btnState.TabIndex = 5;
            btnState.Text = "6. 상태 검색";
            btnState.UseVisualStyleBackColor = true;
            btnState.Click += btnState_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(725, 359);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(63, 45);
            btnHome.TabIndex = 16;
            btnHome.TabStop = false;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnEvent
            // 
            btnEvent.FlatStyle = FlatStyle.Flat;
            btnEvent.Location = new Point(458, 251);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(168, 37);
            btnEvent.TabIndex = 17;
            btnEvent.Text = "10. 이벤트보기";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 416);
            Controls.Add(btnEvent);
            Controls.Add(btnHome);
            Controls.Add(btnWifi);
            Controls.Add(btnVideo);
            Controls.Add(btnData);
            Controls.Add(btnState);
            Controls.Add(btnRelay);
            Controls.Add(btnSensor);
            Controls.Add(btnCritical);
            Controls.Add(btnWarning);
            Controls.Add(btnName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnName;
        private Button btnWarning;
        private Button btnCritical;
        private Button btnSensor;
        private Button btnRelay;
        private Button btnWifi;
        private Button btnVideo;
        private Button btnData;
        private Button btnState;
        private Button btnHome;
        private Button btnEvent;
    }
}