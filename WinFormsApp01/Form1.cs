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

        private void btnTest01_MouseEnter(object sender, EventArgs e)
        {
            // 鼠标进入按钮内时，按钮文字内容变化
            btnTest01.Text = "按钮01";
        }

        private void btnTest01_MouseLeave(object sender, EventArgs e)
        {
            // 鼠标离开按钮时，按钮文字内容恢复
            btnTest01.Text = "btnTest01";
        }
    }
}
