﻿namespace PSSystem
{
    partial class FormSetWifi
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
            btnHome = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Location = new Point(725, 359);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(63, 45);
            btnHome.TabIndex = 21;
            btnHome.TabStop = false;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(316, 9);
            label2.Name = "label2";
            label2.Size = new Size(127, 37);
            label2.TabIndex = 20;
            label2.Text = "WIFI 설정";
            // 
            // FormSetWifi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 416);
            Controls.Add(btnHome);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSetWifi";
            Text = "FormD1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Label label2;
    }
}