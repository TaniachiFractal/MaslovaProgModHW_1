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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void Task1_MouseClick(object sender, MouseEventArgs e)
        {
            picPsyduck.Visible = true;
        }

        private void picPsyduck_MouseClick(object sender, MouseEventArgs e)
        {
            picPsyduck.Visible = false;
        }

        

        private void BTgoNext_MouseClick(object sender, MouseEventArgs e)
        {
            Task2 fr2 = new Task2();
            fr2.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTgoNext_Click(object sender, EventArgs e)
        {

        }

        private void BTgo3_MouseClick(object sender, MouseEventArgs e)
        {
            Task3 fr3 = new Task3();
            fr3.Show();
        }

        private void BTgo4_MouseClick(object sender, MouseEventArgs e)
        {
            Task4 fr4 = new Task4();
            fr4.Show();
        }

        private void BTgo5_MouseClick(object sender, MouseEventArgs e)
        {
            Task5 fr5 = new Task5();
            fr5.Show();
        }

        private void BTgo6_MouseClick(object sender, MouseEventArgs e)
        {
            Task6 fr6 = new Task6();
            fr6.Show();
        }

        private void BTgo7_MouseClick(object sender, MouseEventArgs e)
        {
            Task7 fr7 = new Task7();
            fr7.Show();
        }

        private void BTgo8_MouseClick(object sender, MouseEventArgs e)
        {
            Task8 fr8 = new Task8();
            fr8.Show();
        }
    }

}
