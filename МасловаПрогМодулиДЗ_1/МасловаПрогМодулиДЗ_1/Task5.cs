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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void btEnter_MouseClick(object sender, MouseEventArgs e)
        {
            double A = Convert.ToDouble(tbA.Text);
            double B = Convert.ToDouble(tbB.Text);
            lbOutput.Text = lbOutput.Text + Convert.ToString((A + B) / 2);
        }
    }
}
