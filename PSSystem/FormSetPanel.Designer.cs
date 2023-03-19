namespace PSSystem
{
    partial class FormSetPanel
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
            label1 = new Label();
            btnHome = new Button();
            groupBox1 = new GroupBox();
            textCam4 = new TextBox();
            label4 = new Label();
            textCam3 = new TextBox();
            label5 = new Label();
            textCam2 = new TextBox();
            label3 = new Label();
            textCam1 = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            groupBox2 = new GroupBox();
            textWifiPass = new TextBox();
            label7 = new Label();
            textWifiName = new TextBox();
            label8 = new Label();
            textSensor = new TextBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            textTempWarn = new TextBox();
            label6 = new Label();
            textFireWarn = new TextBox();
            label10 = new Label();
            textArcWarn = new TextBox();
            label11 = new Label();
            groupBox4 = new GroupBox();
            textTempCrit = new TextBox();
            label12 = new Label();
            textFireCrit = new TextBox();
            label13 = new Label();
            textArcCrit = new TextBox();
            label14 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(315, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 15;
            label1.Text = "설정하기(배전반)";
            // 
            // btnHome
            // 
            btnHome.ForeColor = SystemColors.ActiveCaptionText;
            btnHome.Location = new Point(725, 359);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(63, 45);
            btnHome.TabIndex = 17;
            btnHome.TabStop = false;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textCam4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textCam3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textCam2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textCam1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 158);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "배전반 이름";
            // 
            // textCam4
            // 
            textCam4.Location = new Point(84, 118);
            textCam4.Name = "textCam4";
            textCam4.Size = new Size(216, 25);
            textCam4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 121);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 6;
            label4.Text = "4번 : ";
            // 
            // textCam3
            // 
            textCam3.Location = new Point(84, 89);
            textCam3.Name = "textCam3";
            textCam3.Size = new Size(216, 25);
            textCam3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 92);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 4;
            label5.Text = "3번 : ";
            // 
            // textCam2
            // 
            textCam2.Location = new Point(84, 60);
            textCam2.Name = "textCam2";
            textCam2.Size = new Size(216, 25);
            textCam2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 63);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 2;
            label3.Text = "2번 : ";
            // 
            // textCam1
            // 
            textCam1.BackColor = SystemColors.ControlLightLight;
            textCam1.Location = new Point(84, 31);
            textCam1.Name = "textCam1";
            textCam1.Size = new Size(216, 25);
            textCam1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 34);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 0;
            label2.Text = "1번 : ";
            // 
            // btnSave
            // 
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(725, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(63, 45);
            btnSave.TabIndex = 19;
            btnSave.Text = "저장하기";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textWifiPass);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textWifiName);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textSensor);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(392, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 158);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "센서수, Wifi";
            // 
            // textWifiPass
            // 
            textWifiPass.Location = new Point(104, 111);
            textWifiPass.Name = "textWifiPass";
            textWifiPass.Size = new Size(196, 25);
            textWifiPass.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 114);
            label7.Name = "label7";
            label7.Size = new Size(73, 17);
            label7.TabIndex = 4;
            label7.Text = "Wifi 암호: ";
            // 
            // textWifiName
            // 
            textWifiName.Location = new Point(104, 69);
            textWifiName.Name = "textWifiName";
            textWifiName.Size = new Size(196, 25);
            textWifiName.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 72);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 2;
            label8.Text = "Wifi 이름: ";
            // 
            // textSensor
            // 
            textSensor.Location = new Point(104, 31);
            textSensor.Name = "textSensor";
            textSensor.Size = new Size(196, 25);
            textSensor.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 34);
            label9.Name = "label9";
            label9.Size = new Size(60, 17);
            label9.TabIndex = 0;
            label9.Text = "센서 수: ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textTempWarn);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textFireWarn);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textArcWarn);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(23, 228);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(327, 127);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "경고 값";
            // 
            // textTempWarn
            // 
            textTempWarn.Location = new Point(84, 89);
            textTempWarn.Name = "textTempWarn";
            textTempWarn.Size = new Size(216, 25);
            textTempWarn.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 92);
            label6.Name = "label6";
            label6.Size = new Size(37, 17);
            label6.TabIndex = 4;
            label6.Text = "온도:";
            // 
            // textFireWarn
            // 
            textFireWarn.Location = new Point(84, 60);
            textFireWarn.Name = "textFireWarn";
            textFireWarn.Size = new Size(216, 25);
            textFireWarn.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 63);
            label10.Name = "label10";
            label10.Size = new Size(37, 17);
            label10.TabIndex = 2;
            label10.Text = "화재:";
            // 
            // textArcWarn
            // 
            textArcWarn.Location = new Point(84, 31);
            textArcWarn.Name = "textArcWarn";
            textArcWarn.Size = new Size(216, 25);
            textArcWarn.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 34);
            label11.Name = "label11";
            label11.Size = new Size(37, 17);
            label11.TabIndex = 0;
            label11.Text = "아크:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textTempCrit);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(textFireCrit);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(textArcCrit);
            groupBox4.Controls.Add(label14);
            groupBox4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(392, 228);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(327, 127);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "사고 값";
            // 
            // textTempCrit
            // 
            textTempCrit.Location = new Point(84, 89);
            textTempCrit.Name = "textTempCrit";
            textTempCrit.Size = new Size(216, 25);
            textTempCrit.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 92);
            label12.Name = "label12";
            label12.Size = new Size(37, 17);
            label12.TabIndex = 4;
            label12.Text = "온도:";
            // 
            // textFireCrit
            // 
            textFireCrit.Location = new Point(84, 60);
            textFireCrit.Name = "textFireCrit";
            textFireCrit.Size = new Size(216, 25);
            textFireCrit.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 63);
            label13.Name = "label13";
            label13.Size = new Size(37, 17);
            label13.TabIndex = 2;
            label13.Text = "화재:";
            // 
            // textArcCrit
            // 
            textArcCrit.Location = new Point(84, 31);
            textArcCrit.Name = "textArcCrit";
            textArcCrit.Size = new Size(216, 25);
            textArcCrit.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(25, 34);
            label14.Name = "label14";
            label14.Size = new Size(37, 17);
            label14.TabIndex = 0;
            label14.Text = "아크:";
            // 
            // FormSetPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 416);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(btnHome);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSetPanel";
            RightToLeftLayout = true;
            Text = "FormSetPanel";
            Shown += FormSetPanel_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnHome;
        private GroupBox groupBox1;
        private TextBox textCam4;
        private Label label4;
        private TextBox textCam3;
        private Label label5;
        private TextBox textCam2;
        private Label label3;
        private TextBox textCam1;
        private Label label2;
        private Button btnSave;
        private GroupBox groupBox2;
        private TextBox textWifiPass;
        private Label label7;
        private TextBox textWifiName;
        private Label label8;
        private TextBox textSensor;
        private Label label9;
        private GroupBox groupBox3;
        private TextBox textTempWarn;
        private Label label6;
        private TextBox textFireWarn;
        private Label label10;
        private TextBox textArcWarn;
        private Label label11;
        private GroupBox groupBox4;
        private TextBox textTempCrit;
        private Label label12;
        private TextBox textFireCrit;
        private Label label13;
        private TextBox textArcCrit;
        private Label label14;
    }
}