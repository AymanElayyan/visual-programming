using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form3 : Form
    {
        string fullName, addressLine1, addressLine2, postolCode ,city, country;
       
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fullName =  textBox1.Text;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           addressLine1 = textBox2.Text;    
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            city = textBox5.Text;    
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            postolCode = textBox4.Text;
        }

        private void printInfoInLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            addressLine2 = textBox3.Text;
        }

       

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            country = textBox6.Text;
        }

        private void closeInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearInfo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = ""; 
            textBox3.Text = ""; 
            textBox4.Text = ""; 
            textBox5.Text = "";
            textBox6.Text = "";
            printInfoInLabel.Text = "";
        }

        private void printInfo_Click(object sender, EventArgs e)
        {
            printInfoInLabel.Text = "Applicant's name: " + fullName.ToString() + "\n" + "\nApplicant's Address: " + addressLine1 +
                                    ", " + addressLine2 + ", " + postolCode + ", " + city + ", " + country;

        }
    }
}
