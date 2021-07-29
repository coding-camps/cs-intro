namespace WinFormsApp01
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
            btnTest01 = new Button();
            SuspendLayout();
            // 
            // btnTest01
            // 
            btnTest01.Location = new Point(43, 31);
            btnTest01.Name = "btnTest01";
            btnTest01.Size = new Size(229, 105);
            btnTest01.TabIndex = 0;
            btnTest01.Text = "btnTest01";
            btnTest01.UseVisualStyleBackColor = true;
            btnTest01.Click += btnTest01_Click;
            btnTest01.MouseEnter += btnTest01_MouseEnter;
            btnTest01.MouseLeave += btnTest01_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1642, 929);
            Controls.Add(btnTest01);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest01;
    }
}
