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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(289, 46);
            label1.Name = "label1";
            label1.Size = new Size(199, 37);
            label1.TabIndex = 15;
            label1.Text = "배전반 이름 설정";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(693, 441);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(63, 45);
            btnHome.TabIndex = 17;
            btnHome.TabStop = false;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // FormSetPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(btnHome);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSetPanel";
            RightToLeftLayout = true;
            Text = "FormSetPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnHome;
    }
}