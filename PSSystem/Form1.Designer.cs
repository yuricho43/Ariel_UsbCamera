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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblModelName = new Label();
            lblDate = new Label();
            label1 = new Label();
            btnMenu = new Button();
            panelMiddle = new Panel();
            timerTime = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(lblModelName);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 0;
            // 
            // lblModelName
            // 
            lblModelName.AutoSize = true;
            lblModelName.BackColor = SystemColors.Highlight;
            lblModelName.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblModelName.ForeColor = SystemColors.ButtonHighlight;
            lblModelName.Location = new Point(12, 12);
            lblModelName.Name = "lblModelName";
            lblModelName.Size = new Size(211, 37);
            lblModelName.TabIndex = 11;
            lblModelName.Text = "KENTC-23NP-P";
            lblModelName.Visible = false;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = SystemColors.Highlight;
            lblDate.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.ForeColor = SystemColors.ButtonHighlight;
            lblDate.Location = new Point(590, 18);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(200, 29);
            lblDate.TabIndex = 10;
            lblDate.Text = "2023-03-06 12:00:00";
            lblDate.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(525, 18);
            label1.Name = "label1";
            label1.Size = new Size(63, 29);
            label1.TabIndex = 9;
            label1.Text = "날짜 :";
            label1.Visible = false;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(323, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(125, 37);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "설정";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Visible = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelMiddle
            // 
            panelMiddle.BackColor = SystemColors.ScrollBar;
            panelMiddle.Dock = DockStyle.Fill;
            panelMiddle.Location = new Point(0, 64);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(800, 416);
            panelMiddle.TabIndex = 2;
            // 
            // timerTime
            // 
            timerTime.Enabled = true;
            timerTime.Interval = 1000;
            timerTime.Tick += timerTime_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 480);
            Controls.Add(panelMiddle);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PSSystem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMiddle;
        private Button btnMenu;
        private Label lblDate;
        private Label label1;
        private Label lblModelName;
        private System.Windows.Forms.Timer timerTime;
    }
}