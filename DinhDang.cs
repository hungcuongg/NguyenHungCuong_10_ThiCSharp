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
    public partial class DinhDang : Form
    {
        public DinhDang()
        {
            InitializeComponent();
        }

        private void DinhDang_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;   
            switch (r.Name)
            {
                case "radRed":
                    {
                        lblLapTrinh.ForeColor = Color.Red;
                        txtNhapTen.ForeColor = Color.Red;
                    }
                    break;

                case "radGreen":
                    {
                        lblLapTrinh.ForeColor = Color.Green;
                        txtNhapTen.ForeColor = Color.Green;
                    }
                    break;
                case "radBlue":
                    {
                        lblLapTrinh.ForeColor = Color.Blue;
                        txtNhapTen.ForeColor = Color.Blue;
                    }
                    break;
                case "radBlack":
                    {
                        lblLapTrinh.ForeColor = Color.Black;
                        txtNhapTen.ForeColor = Color.Black;
                    }
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size,
           lblLapTrinh.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size,
           lblLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size,
           lblLapTrinh.Font.Style ^ FontStyle.Underline);
        }
    }
}
