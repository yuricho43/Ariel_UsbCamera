﻿namespace PSSystem
{
    partial class FormSetNumSensor
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
            btnHome.Location = new Point(714, 482);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(63, 45);
            btnHome.TabIndex = 23;
            btnHome.TabStop = false;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(279, 41);
            label2.Name = "label2";
            label2.Size = new Size(151, 37);
            label2.TabIndex = 22;
            label2.Text = "센서 수 설정";
            // 
            // FormSetNumSensor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(btnHome);
            Controls.Add(label2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSetNumSensor";
            Text = "FormB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Label label2;
    }
}