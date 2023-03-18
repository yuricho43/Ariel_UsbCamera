namespace PSSystem
{
    partial class FormSetVideo
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
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnCam1 = new Button();
            btnCam2 = new Button();
            btnCam3 = new Button();
            btnCam4 = new Button();
            label1 = new Label();
            btnHome = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(396, 181);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(300, 170);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(94, 181);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(300, 170);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(396, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(94, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnCam1
            // 
            btnCam1.Location = new Point(12, 60);
            btnCam1.Name = "btnCam1";
            btnCam1.Size = new Size(75, 23);
            btnCam1.TabIndex = 10;
            btnCam1.Text = "카메라1";
            btnCam1.UseVisualStyleBackColor = true;
            btnCam1.Click += btnCam1_Click;
            // 
            // btnCam2
            // 
            btnCam2.Location = new Point(713, 60);
            btnCam2.Name = "btnCam2";
            btnCam2.Size = new Size(75, 23);
            btnCam2.TabIndex = 11;
            btnCam2.Text = "카메라2";
            btnCam2.UseVisualStyleBackColor = true;
            btnCam2.Click += btnCam2_Click;
            // 
            // btnCam3
            // 
            btnCam3.Location = new Point(4, 247);
            btnCam3.Name = "btnCam3";
            btnCam3.Size = new Size(75, 23);
            btnCam3.TabIndex = 12;
            btnCam3.Text = "카메라3";
            btnCam3.UseVisualStyleBackColor = true;
            btnCam3.Click += btnCam3_Click;
            // 
            // btnCam4
            // 
            btnCam4.Location = new Point(705, 247);
            btnCam4.Name = "btnCam4";
            btnCam4.Size = new Size(75, 23);
            btnCam4.TabIndex = 13;
            btnCam4.Text = "카메라4";
            btnCam4.UseVisualStyleBackColor = true;
            btnCam4.Click += btnCam4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 359);
            label1.Name = "label1";
            label1.Size = new Size(65, 37);
            label1.TabIndex = 14;
            label1.Text = "영상";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(725, 359);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(63, 45);
            btnHome.TabIndex = 15;
            btnHome.TabStop = false;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(94, 370);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next  Cam";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FormSetVideo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 416);
            Controls.Add(btnNext);
            Controls.Add(btnHome);
            Controls.Add(label1);
            Controls.Add(btnCam4);
            Controls.Add(btnCam3);
            Controls.Add(btnCam2);
            Controls.Add(btnCam1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSetVideo";
            Text = "FormD2";
            FormClosed += FormSetVideo_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnCam1;
        private Button btnCam2;
        private Button btnCam3;
        private Button btnCam4;
        private Label label1;
        private Button btnHome;
        private Button btnNext;
    }
}