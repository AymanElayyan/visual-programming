using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Weight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            float acceleration = 9.8f;
            if (float.TryParse(txt_mass.Text, out float mass))
            {
                float wight = mass * acceleration;
                if (wight > 1000)
                {
                    MessageBox.Show("its too heavy");
                }
                else if (wight < 10) 
                {
                    MessageBox.Show("its too light");
                } 
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_mass.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_mass_TextChanged(object sender, EventArgs e)
        {
            txt_mass.Focus();
        }
    }
}
