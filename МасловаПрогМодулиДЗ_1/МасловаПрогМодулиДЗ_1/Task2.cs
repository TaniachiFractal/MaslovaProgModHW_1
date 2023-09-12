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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Task2_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Goldenrod;
            
        }

        private void Task2_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }
    }
}
