using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleLoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                //interestOfMonth_1-> for first month
                //interestOfMonth-> for 47 months remaining
                double rate = 0;
                double principal = double.Parse(txt_CostOfVehicle.Text) - double.Parse(txt_AmountOfDownPayment.Text);
                int duration = int.Parse(txt_NumberOfMonths.Text);
                double paymentOfMonth_1 = 0;
                double interestOfMonth_1 = 0;
                double interestOfMonth = 0;
                double principalOfMonth_1 = 0;
                double principalOfMonth = 0;
                double interest = 0;

                //check RedioButton to set the rate if a new or used car
                if (rad_New.Checked)
                {
                    lbl_AnnualInterestRate.Text = "8.00%";
                    rate = 0.08;
                }
                else if (rad_Used.Checked)
                {
                    lbl_AnnualInterestRate.Text = "12.00%";
                    rate = 0.12;
                }
                else
                {
                    MessageBox.Show("Please chose one from the Radio Button!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (txt_CostOfVehicle.Text == "" || txt_NumberOfMonths.Text == "" || txt_AmountOfDownPayment.Text == "") 
                {
                    MessageBox.Show("Please fill the information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                //for first month 
                paymentOfMonth_1 = principal * (rate / 12 * Math.Pow(1 + rate / 12, duration)) / (Math.Pow(1 + rate / 12, duration) - 1);
                interestOfMonth_1 = principal * (rate / 12);
                principalOfMonth_1 = paymentOfMonth_1 - interestOfMonth_1;
                listBox1.Items.Add("Month 01: payment =" + paymentOfMonth_1.ToString("f2") + " , interest = " + interestOfMonth_1.ToString("f2") + " , principal = " + principalOfMonth_1.ToString("f2"));


                //for second month
                interestOfMonth = interestOfMonth_1 - (paymentOfMonth_1 * rate / 12);
                principalOfMonth_1 = paymentOfMonth_1 - interestOfMonth;

                for (int i = 1; i < 48; i++)
                {
                    interest = interestOfMonth;
                    principalOfMonth = paymentOfMonth_1 - interestOfMonth;

                    if (i < 9)
                        listBox1.Items.Add("Month 0" + (i + 1) + ": payment =" + paymentOfMonth_1.ToString("f2") + " , interest = " + interestOfMonth.ToString("f2") + " , principal = " + principalOfMonth.ToString("f2"));
                    else
                        listBox1.Items.Add("Month " + (i + 1) + ": payment =" + paymentOfMonth_1.ToString("f2") + " , interest = " + interestOfMonth.ToString("f2") + " , principal = " + principalOfMonth.ToString("f2"));

                    interestOfMonth = interest - (paymentOfMonth_1 * rate / 12);

                }
            }
            catch 
            {
                MessageBox.Show("Please fill the information!", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
            }

            txt_CostOfVehicle.Focus();

        }

        private void btn_Exit_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clear_Click (object sender, EventArgs e)
        {
            txt_AmountOfDownPayment.Text = "";
            txt_CostOfVehicle.Text = string.Empty;
            txt_NumberOfMonths.Text = string.Empty;
            lbl_AnnualInterestRate.Text = string.Empty;
            listBox1.Items.Clear();
            txt_CostOfVehicle.Focus();

        }

        private void txt_CostOfVehicle_TextChanged (object sender, EventArgs e)
        {

        }

        private void Form1_Load (object sender, EventArgs e)
        {
            
        }
    }
}

