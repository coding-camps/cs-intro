namespace WinFormsApp01
{
    partial class MainForm
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
            labelWelcome = new Label();
            btnCaculate = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(49, 56);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(0, 31);
            labelWelcome.TabIndex = 0;
            // 
            // btnCaculate
            // 
            btnCaculate.Location = new Point(313, 336);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(150, 46);
            btnCaculate.TabIndex = 1;
            btnCaculate.Text = "计算总价";
            btnCaculate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCaculate);
            Controls.Add(labelWelcome);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += Main_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button btnCaculate;
    }
}
