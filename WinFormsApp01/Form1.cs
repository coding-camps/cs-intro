namespace WinFormsApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initBtn1();
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

        // 新创建一个按钮 newBtn1
        private Button newBtn1;

        private void initBtn1()
        {
            // newBtn1 的创建过程
            newBtn1 = new Button();
            newBtn1.Text = "自创按钮1";
            newBtn1.Location = new Point(300, 36);
            newBtn1.Size = new Size(168, 98);
            newBtn1.Click += newBtn1_Click;
            Controls.Add(newBtn1);
        }

        private void newBtn1_Click(object sender, EventArgs e)
        {
            // newBtn1 的click事件
            newBtn1.ForeColor = Color.CadetBlue;
        }
    }
}
