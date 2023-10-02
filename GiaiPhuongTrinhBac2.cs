using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NguyenHungCuong_30_ThiCSharp
{
    public partial class GiaiPhuongTrinhBac2 : Form
    {
        public GiaiPhuongTrinhBac2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intA, intB, intC;
            double delta, x1, x2;
            intA = Convert.ToInt32(txtsoa.Text);
            intB = Convert.ToInt32(txtsob.Text);
            intC = Convert.ToInt32(txtsoc.Text);
            string strB = (intB < 0) ? " - " + Math.Abs(intB) : " + " + Math.Abs(intB);
            string strC = (intC < 0) ? " - " + Math.Abs(intC) : " + " + Math.Abs(intC);
            lblPT.Text = intA + "x" + ("\u00B2") + strB + "x" + strC + " = 0";
            if (intA == 0)
            {
                giaiPTbac1(intB, intC, lblkq);
            }
            else
            {
                delta = (double)Math.Pow(intB, 2) - 4 * intA * intC;
                lblkq.Text = "Delta = " + Convert.ToString(delta) + "\n"; 
                if (delta < 0)
                {
                    // phương trình đã cho vô nghiệm.
                    lblkq.Text += "Phương trình vô nghiệm\n";
                }
                if (delta == 0)
                {
                    // phương trình có nghiệm kép x=-b/2a
                    lblkq.Text += "Phương trình có nghiệm kép x1 = x2 = " + (double)(-intB / (2 * intA)) + "\n";

                }
                if (delta > 0)
                {
                    // phương trình có 2 nghiệm phân biệt.
                    x1 = (double)(-intB + Math.Sqrt(delta)) / (2 * intA);
                    x2 = (double)(-intB - Math.Sqrt(delta)) / (2 * intA);
                          lblkq.Text += "Phương trình có 2 nghiệm\n";
                    lblkq.Text += "x1 = " + x1 + "\n";
                    lblkq.Text += "x2 = " + x2 + "\n";
                }
            }

        }
        private void GiaiPhuongTrinhBac2_Load(object sender, EventArgs e)
        {
        }
        static void giaiPTbac1(int intA, int intB, Control lblKQinFunction)
        {
            // bx + c = 0
            lblKQinFunction.Text = "";
            if (intA == 0 && intB == 0)
            {
                //Console.WriteLine(" Phuong trinh co vo so nghiem");
                lblKQinFunction.Text = "Phương trình có vô số nghiệm\n";
            }
            else if (intA == 0 && intB != 0)
            {
                lblKQinFunction.Text = "Phương trình vô nghiệm\n";
            }
            else
            {
                //Console.WriteLine(" Phuong trinh co 1 nghiem duy nhat x = {0}", (double)-intB / intA);
                lblKQinFunction.Text = "Phương trình có 1 nghiệm duy nhất x = " + ((double)-intB / intA) + "\n";
            }
        }

        private void trbsoa_Scroll(object sender, EventArgs e)
        {
            txtsoa.Text = trbsoa.Value.ToString();
        }

        private void trbsob_Scroll(object sender, EventArgs e)
        {
            txtsob.Text = trbsob.Value.ToString();
        }

        private void trbsoc_Scroll(object sender, EventArgs e)
        {
            txtsoc.Text = trbsoc.Value.ToString();
        }
    }
}
