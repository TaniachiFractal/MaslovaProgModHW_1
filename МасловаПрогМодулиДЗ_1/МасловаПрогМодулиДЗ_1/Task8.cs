using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МасловаПрогМодулиДЗ_1
{
    public partial class Task8 : Form
    {
        public Task8()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btPlus_MouseClick(object sender, MouseEventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double c = a + b;
            tbOutput.Text = c.ToString("F3");
        }

        private void btMinus_MouseClick(object sender, MouseEventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double c = a - b;
            tbOutput.Text = c.ToString("F3");
        }

        private void btMul_MouseClick(object sender, MouseEventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double c = a * b;
            tbOutput.Text = c.ToString("F3");
        }

        private void btDiv_MouseClick(object sender, MouseEventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double c;

            if (b != 0)
            {
                c = a / b;
                tbOutput.Text = c.ToString("F3");
            }
            else tbOutput.Text = "±∞";
        }

        private void btPow_MouseClick(object sender, MouseEventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            double c = a;

            if (b > 0 && b < 100)
            {
                for (int i = 1; i < b; i++) c = c * a;
                tbOutput.Text = c.ToString("F3");
            }
            else if (b < 0 && b > -100)
            {
                for (int i = 0; i <= -1*b; i++) c = c / a;
                tbOutput.Text = c.ToString("F3");
            }
            else if (b==0)
                tbOutput.Text = "1";
            else
                tbOutput.Text = "Я не знаю";


        }

        private void btEqual_MouseEnter(object sender, EventArgs e)
        {
            lbsmile.Visible = true;
        }

        private void btEqual_MouseLeave(object sender, EventArgs e)
        {
            lbsmile.Visible = false;
        }
    }
}
