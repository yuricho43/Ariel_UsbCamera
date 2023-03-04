namespace PSSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCam4 = new System.Windows.Forms.Button();
            this.btnCam3 = new System.Windows.Forms.Button();
            this.btnCam2 = new System.Windows.Forms.Button();
            this.btnCam1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnCam4);
            this.panel1.Controls.Add(this.btnCam3);
            this.panel1.Controls.Add(this.btnCam2);
            this.panel1.Controls.Add(this.btnCam1);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.btnB);
            this.panel1.Controls.Add(this.btnA);
            this.panel1.Controls.Add(this.btnMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnCam4
            // 
            this.btnCam4.Location = new System.Drawing.Point(144, 35);
            this.btnCam4.Name = "btnCam4";
            this.btnCam4.Size = new System.Drawing.Size(75, 23);
            this.btnCam4.TabIndex = 8;
            this.btnCam4.Text = "Cam4";
            this.btnCam4.UseVisualStyleBackColor = true;
            this.btnCam4.Click += new System.EventHandler(this.btnCam4_Click);
            // 
            // btnCam3
            // 
            this.btnCam3.Location = new System.Drawing.Point(144, 9);
            this.btnCam3.Name = "btnCam3";
            this.btnCam3.Size = new System.Drawing.Size(75, 23);
            this.btnCam3.TabIndex = 7;
            this.btnCam3.Text = "Cam3";
            this.btnCam3.UseVisualStyleBackColor = true;
            this.btnCam3.Click += new System.EventHandler(this.btnCam3_Click);
            // 
            // btnCam2
            // 
            this.btnCam2.Location = new System.Drawing.Point(12, 38);
            this.btnCam2.Name = "btnCam2";
            this.btnCam2.Size = new System.Drawing.Size(75, 23);
            this.btnCam2.TabIndex = 6;
            this.btnCam2.Text = "Cam2";
            this.btnCam2.UseVisualStyleBackColor = true;
            this.btnCam2.Click += new System.EventHandler(this.btnCam2_Click);
            // 
            // btnCam1
            // 
            this.btnCam1.Location = new System.Drawing.Point(12, 9);
            this.btnCam1.Name = "btnCam1";
            this.btnCam1.Size = new System.Drawing.Size(75, 23);
            this.btnCam1.TabIndex = 5;
            this.btnCam1.Text = "Cam1";
            this.btnCam1.UseVisualStyleBackColor = true;
            this.btnCam1.Click += new System.EventHandler(this.btnCam1_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(363, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(249, 19);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 32);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(699, 19);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 32);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "To B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(604, 19);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 32);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "To A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(512, 19);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 32);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "To MAIN";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 64);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(800, 536);
            this.panelMiddle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSSystem";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelMiddle;
        private Button btnB;
        private Button btnA;
        private Button btnMain;
        private Button btnNext;
        private Button btnPrev;
        private Button btnCam2;
        private Button btnCam1;
        private Button btnCam4;
        private Button btnCam3;
    }
}