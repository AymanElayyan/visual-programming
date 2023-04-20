using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Dates
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

        private void btn_Magic_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txt_Day.Text, out int day))
            {
                MessageBox.Show("The Day isn't in the numerical value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (!int.TryParse(txt_year.Text, out int year))
            {
                MessageBox.Show("The Year isn't in the numerical value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (!int.TryParse(txt_month.Text, out int month))
            {
                MessageBox.Show("The Month isn't in the numerical value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (year < 1 || year > 99)
            {
                MessageBox.Show("the year must be between [1-99] in the year text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (month < 1 || month > 12)
            {
                MessageBox.Show("the month must be between [1-12] in the month text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day < 1 || day > 31)
                {
                    MessageBox.Show("The day must be between [1-30] in the day text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {

                if (1 < day || day > 30)
                {
                    MessageBox.Show("The day must be between [1-30] in the day text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                                       
            }                                           
                                                        
            else if (month == 2)                        
            {                                           
                                                        
                if (day < 1 || day > 29)                
                {                                       
                    MessageBox.Show("The day must be between [1-29] in the day text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            bool isMagicYear = month * day == year;
            string yourDate = month + "/" + day + "/" + year;
            if (isMagicYear)
            {
                MessageBox.Show("The date of " + yourDate + " is a magic date!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The date of " + yourDate + " is not a magic date!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }






        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Day.Text = "";
            txt_month.Text = "";
            txt_year.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_month_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Day_TextChanged(object sender, EventArgs e)
        {
            txt_Day.Focus();
        }
    }
}
