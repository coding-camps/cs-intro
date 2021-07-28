namespace WinFormsApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest01_Click(object sender, EventArgs e)
        {
            // 点击时改变按钮文字颜色，点击后按钮文字颜色保持不变。
            btnTest01.ForeColor = Color.BlueViolet;
        }
    }
}
