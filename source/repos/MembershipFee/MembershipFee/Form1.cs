using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembershipFee
{
    public partial class Form1 : Form
    {
        double optionsTotal = 0;
        double baseFee = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            optionsTotal = 0;
            baseFee = 0;
            try
            {
                if (chkYoga.Checked)
                    optionsTotal += 10;
                if (chkKarate.Checked)
                    optionsTotal += 30;
                if (chkTrainer.Checked)
                    optionsTotal += 50;

                lblMonthIyFee.Text = (baseFee + optionsTotal).ToString();
                int.TryParse(txtMonths.Text, out int months);
                lblTotalFee.Text = (months * (baseFee + optionsTotal)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }

            bool noneChecked = true;
            foreach (Control control in Form1.Controls)
            {
                if ((control is CheckBox checkBox && checkBox.Checked) && (control is RadioButton radioButton && radioButton.Checked))
                {
                    noneChecked = false;
                    break;
                }
            }

            if (noneChecked)
            {
                MessageBox.Show("Please select one");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            baseFee = 0;
            optionsTotal = 0;
            txtMonths.Text = "";
            lblMonthIyFee.Text = "";
            lblTotalFee.Text = "";
            radAduIt.Checked = false;   
            radSenior.Checked = false;
            radStudent.Checked = false; 
            radChild.Checked = false;
            chkKarate.Checked = false;
            chkTrainer.Checked = false; 
            chkYoga.Checked = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkKarate_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkTrainer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkYoga_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radAduIt_CheckedChanged(object sender, EventArgs e)
        {
            baseFee += 40;
        }

        private void radStudent_CheckedChanged(object sender, EventArgs e)
        {
            baseFee += 25;
        }

        private void radChild_CheckedChanged(object sender, EventArgs e)
        {
            baseFee += 20;
        }

        private void radSenior_CheckedChanged(object sender, EventArgs e)
        {
            baseFee += 30;
        }

        private void txtMonths_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalFee_Click(object sender, EventArgs e)
        {

        }
    }
}
