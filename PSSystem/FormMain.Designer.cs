namespace PSSystem
{
    partial class FormMain
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblTemp = new Label();
            lblSound = new Label();
            lblVib = new Label();
            lblFire = new Label();
            lblArc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(306, 21);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 17;
            label1.Text = "동작상태 보기";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(158, 251);
            label4.Name = "label4";
            label4.Size = new Size(103, 45);
            label4.TabIndex = 20;
            label4.Text = "진동: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(158, 191);
            label3.Name = "label3";
            label3.Size = new Size(114, 45);
            label3.TabIndex = 19;
            label3.Text = "화재 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(158, 131);
            label2.Name = "label2";
            label2.Size = new Size(103, 45);
            label2.TabIndex = 18;
            label2.Text = "아크 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(158, 311);
            label5.Name = "label5";
            label5.Size = new Size(114, 45);
            label5.TabIndex = 21;
            label5.Text = "음파 : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(158, 371);
            label6.Name = "label6";
            label6.Size = new Size(114, 45);
            label6.TabIndex = 22;
            label6.Text = "온도 : ";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTemp.ForeColor = SystemColors.ControlLightLight;
            lblTemp.Location = new Point(265, 371);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(90, 45);
            lblTemp.TabIndex = 27;
            lblTemp.Text = "25도";
            // 
            // lblSound
            // 
            lblSound.AutoSize = true;
            lblSound.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblSound.ForeColor = SystemColors.ControlLightLight;
            lblSound.Location = new Point(265, 311);
            lblSound.Name = "lblSound";
            lblSound.Size = new Size(148, 45);
            lblSound.TabIndex = 26;
            lblSound.Text = "이상없음";
            // 
            // lblVib
            // 
            lblVib.AutoSize = true;
            lblVib.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblVib.ForeColor = SystemColors.ControlLightLight;
            lblVib.Location = new Point(265, 251);
            lblVib.Name = "lblVib";
            lblVib.Size = new Size(148, 45);
            lblVib.TabIndex = 25;
            lblVib.Text = "이상없음";
            // 
            // lblFire
            // 
            lblFire.AutoSize = true;
            lblFire.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblFire.ForeColor = SystemColors.ControlLightLight;
            lblFire.Location = new Point(265, 191);
            lblFire.Name = "lblFire";
            lblFire.Size = new Size(148, 45);
            lblFire.TabIndex = 24;
            lblFire.Text = "이상없음";
            // 
            // lblArc
            // 
            lblArc.AutoSize = true;
            lblArc.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblArc.ForeColor = SystemColors.ControlLightLight;
            lblArc.Location = new Point(265, 131);
            lblArc.Name = "lblArc";
            lblArc.Size = new Size(148, 45);
            lblArc.TabIndex = 23;
            lblArc.Text = "이상없음";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(lblTemp);
            Controls.Add(lblSound);
            Controls.Add(lblVib);
            Controls.Add(lblFire);
            Controls.Add(lblArc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label lblTemp;
        private Label lblSound;
        private Label lblVib;
        private Label lblFire;
        private Label lblArc;
    }
}