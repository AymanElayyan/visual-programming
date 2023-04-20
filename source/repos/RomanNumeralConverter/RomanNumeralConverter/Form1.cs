using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_OrginalNumber_TextChanged(object sender, EventArgs e)
        {
            txt_OrginalNumber.Focus();  
        }

        private void btn_Converter_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txt_OrginalNumber.Text, out int number))
            {
                if (number >= 11 || number <= 20)
                {
                    switch (number)
                    {
                        case 11:
                            lb_RomanicNumber.Text = "XI";
                            break;
                        case 12:
                            lb_RomanicNumber.Text = "XII";
                            break;
                        case 13:
                            lb_RomanicNumber.Text = "XIII";
                            break;
                        case 14:
                            lb_RomanicNumber.Text = "XIV";
                            break;
                        case 15:
                            lb_RomanicNumber.Text = "XV";
                            break;
                        case 16:
                            lb_RomanicNumber.Text = "XVI";
                            break;
                        case 17:
                            lb_RomanicNumber.Text = "XVII";
                            break;
                        case 18:
                            lb_RomanicNumber.Text = "XVIII";
                            break;
                        case 19:
                            lb_RomanicNumber.Text = "XIX";
                            break;
                        case 20:
                            lb_RomanicNumber.Text = "XIII";
                            break;
                        default:
                            MessageBox.Show("Out of the  range!");
                            break;
                    }

                }
                
            }
            else
            {
                MessageBox.Show("Invalid Number!");
            }
        }

        private void lb_RomanicNumber_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lb_RomanicNumber.Text = "";
            txt_OrginalNumber.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
