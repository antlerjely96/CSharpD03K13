using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuaBaiTap1
{
    public partial class Form1 : Form
    {
        
        //Khai báo a, b
        private double a, b;

        private double nhap(TextBox textBox)
        {
            double n = double.Parse(textBox.Text);
            return n;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            //Lấy a
            a = nhap(tbA);
            //Lấy b
            b = nhap(tbB);
            //Tính a + b
            double tong = a + b;
            //Hiển thị kết quả
            tbTong.Text = tong.ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            //Lấy a
            a = nhap(tbA);
            //Lấy b
            b = nhap(tbB);
            //Tính a - b
            double hieu = a - b;
            //Hiển thị kết quả
            tbHieu.Text = hieu.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            //Lấy a
            a = nhap(tbA);
            //Lấy b
            b = nhap(tbB);
            //Tính a * b
            double tich = a * b;
            //Hiển thị kết quả
            tbTich.Text = tich.ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            //Lấy a
            a = nhap(tbA);
            //Lấy b
            b = nhap(tbB);
            //Tính a / b
            double thuong = a / b;
            //Hiển thị kết quả
            tbThuong.Text = thuong.ToString();
        }

        private void btnTinhAll_Click(object sender, EventArgs e)
        {
            btnTong_Click(null, null);
            btnHieu_Click(null, null);
            btnTich_Click(null, null);
            btnThuong_Click(null, null);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbA.Text = tbB.Text = tbTong.Text = tbHieu.Text = tbTich.Text = tbThuong.Text = "";
        }
    }
}