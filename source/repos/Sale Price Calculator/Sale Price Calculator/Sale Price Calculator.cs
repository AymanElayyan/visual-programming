using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace Sale_Price_Calculator
{
    
    public partial class Form1 : Form
    {
        float originalPrice;
        float discountPercentage;
        float calculated;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (PriceTextBox.Text != "" && discountPercentageTextBox.Text != "")
            {
                // Write your code here
                calculated = originalPrice - discountPercentage;
                salePriceLabel.Text = calculated.ToString();
            }
            else
            {
                MessageBox.Show("Make sure both textboxs are filled up with number!",
                                "",MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void discPercentagePromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            originalPrice = float.Parse(PriceTextBox.Text);
        }

        private void discountPercentageTextBox_TextChanged(object sender, EventArgs e)
        {
            discountPercentage = float.Parse(discountPercentageTextBox.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void salePriceLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            //show the second FORM
            Form2 form_ = new Form2();  
            form_.Show();
               
            
        }
    }
}
