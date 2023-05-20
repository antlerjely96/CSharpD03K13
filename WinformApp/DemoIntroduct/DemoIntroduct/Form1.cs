using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoIntroduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ ô nhập a
            double a = double.Parse(tb_a.Text);
            //Lấy dữ liệu từ ô nhập b
            double b = double.Parse(tb_b.Text);
            //Tính a + b
            double tong = a + b;
            //Hiển thị ra ô input tổng
            tb_tong.Text = tong.ToString();
        }
    }
}