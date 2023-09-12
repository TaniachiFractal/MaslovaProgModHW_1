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
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void btEnter_MouseClick(object sender, MouseEventArgs e)
        {
            lbCorrect.Text = (TBpassword.Text == "qwerty2005") ? "Ваш пароль - ВЕРНЫЙ!!!" : "Ваш пароль - НЕВЕРНЫЙ";
        }
    }
}
