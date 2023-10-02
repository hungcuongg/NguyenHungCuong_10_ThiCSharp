using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHungCuong_30_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hovaten = "Nguyễn Hùng Cường";
            string mssv = "3271653651";
            string monthi = "Lập trình Windows 2 - C#";

            lblsv.Text = "Họ và Tên: " + hovaten;
            lblsv.Text += "\n MSSV: " + mssv;
            lblsv.Text += "\n Ngày thi: " + System.DateTime.Now.ToString();
            lblsv.Text += "\n Môn thi: " + monthi;
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình tiện ích","Thông tin");
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();
            gpt.Show();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DinhDang dd =new DinhDang();
            dd.Show();  
        }
    }
}
