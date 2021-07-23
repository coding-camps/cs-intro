namespace WinFormsApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 在窗体中手动添加一个按钮
            Button btn = new Button();
            btn.Text = "一个按钮";
            btn.Left = 20;
            btn.Top = 20;
            btn.Size = new Size(150, 50);
            this.Controls.Add(btn);
        }
    }
}
