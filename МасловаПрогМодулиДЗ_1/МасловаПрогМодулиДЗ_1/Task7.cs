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
    public partial class Task7 : Form
    {
        public Task7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTposled_MouseClick(object sender, MouseEventArgs e)
        {
            double r1 = Convert.ToDouble(tb1.Text);
            double r2 = Convert.ToDouble(tb2.Text);
            tbOutput.Text = Convert.ToString(r1 + r2);
        }

        private void BTparallel_MouseClick(object sender, MouseEventArgs e)
        {
            double r1 = Convert.ToDouble(tb1.Text);
            double r2 = Convert.ToDouble(tb2.Text);
            double r12opposite = (1 / r1) + (1 / r2);
            double r12 = 1 / r12opposite;
            tbOutput.Text = r12.ToString("F10");
        }
    }
}
