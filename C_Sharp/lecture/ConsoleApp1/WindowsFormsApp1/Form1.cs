using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 點擊時會觸發
        private void button1_Click(object sender, EventArgs e)
        {
            // 顯示文字
            MessageBox.Show("click");
        }

        // 載入視窗程式
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("loading...");
        }
    }
}
