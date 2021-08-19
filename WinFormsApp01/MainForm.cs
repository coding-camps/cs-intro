namespace WinFormsApp01
{
    public partial class MainForm : Form
    {
        public MainForm(string name)
        {
            InitializeComponent();
            showWelcomeInfo(name);
        }

        public MainForm()
        {
            InitializeComponent();
            showWelcomeInfo();
        }

        private void showWelcomeInfo()
        {
            string name = Constrants.INSTANCE.username;
            this.labelWelcome.Text = $"你好！欢迎{name}~!";
        }

        private void showWelcomeInfo(string name)
        {
            this.labelWelcome.Text = $"你好！欢迎{name}~!";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            // 单击时计算总价
            string priceStr = textPrice.Text;
            string numberStr = textNumber.Text;
            double price = 0;
            double number = 0;
            try
            {
                price = double.Parse(priceStr);
                number = double.Parse(numberStr);
            }
            catch
            {
                MessageBox.Show("单价和数量必须为正常的数字。");
            }
            double total = price * number;
            textTotal.Text = total.ToString();
        }
    }
}
