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
            labelPrice = new Label();
            textPrice = new TextBox();
            textNumber = new TextBox();
            labelNumber = new Label();
            textTotal = new TextBox();
            labelTotal = new Label();
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
            btnCaculate.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCaculate.Location = new Point(313, 336);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new Size(150, 46);
            btnCaculate.TabIndex = 1;
            btnCaculate.Text = "计算总价";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(253, 133);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(62, 31);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "单价";
            // 
            // textPrice
            // 
            textPrice.Location = new Point(359, 133);
            textPrice.MaxLength = 8;
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(253, 38);
            textPrice.TabIndex = 3;
            // 
            // textNumber
            // 
            textNumber.Location = new Point(359, 187);
            textNumber.MaxLength = 8;
            textNumber.Name = "textNumber";
            textNumber.Size = new Size(253, 38);
            textNumber.TabIndex = 5;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(253, 187);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(62, 31);
            labelNumber.TabIndex = 4;
            labelNumber.Text = "数量";
            // 
            // textTotal
            // 
            textTotal.BackColor = SystemColors.ButtonHighlight;
            textTotal.Location = new Point(359, 240);
            textTotal.MaxLength = 17;
            textTotal.Name = "textTotal";
            textTotal.ReadOnly = true;
            textTotal.Size = new Size(253, 38);
            textTotal.TabIndex = 7;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(253, 240);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(62, 31);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "总价";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textTotal);
            Controls.Add(labelTotal);
            Controls.Add(textNumber);
            Controls.Add(labelNumber);
            Controls.Add(textPrice);
            Controls.Add(labelPrice);
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
        private Label labelPrice;
        private TextBox textPrice;
        private TextBox textNumber;
        private Label labelNumber;
        private TextBox textTotal;
        private Label labelTotal;
    }
}
