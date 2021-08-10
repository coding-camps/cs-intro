using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp01
{
    public partial class Main : Form
    {
        public Main(string name)
        {
            InitializeComponent();
            showWelcomeInfo(name);
        }

        private void showWelcomeInfo(string name)
        {
            this.labelWelcome.Text = $"你好！欢迎{name}~!";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
