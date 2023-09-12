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
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
        }

        private void Task6_Load(object sender, EventArgs e)
        {

        }

        private void field_MouseClick(object sender, MouseEventArgs e)
        {
            double a = Convert.ToDouble(tbWid.Text);
            double b = Convert.ToDouble(tbLeng.Text);

            lbP.Text = lbP.Text + Convert.ToString(a + a + b + b);
            lbS.Text = lbS.Text + Convert.ToString(a*b);
        }
    }
}
