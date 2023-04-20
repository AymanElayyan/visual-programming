using System;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form2: Form
    {
        float firstNum, secNum;

        public Form2()
        {
            InitializeComponent();
        }

        private void firstNumber_TextChanged(object sender, EventArgs e)
        {
            firstNum = float.Parse(firstNumber.Text);

        }

        private void resulte_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            operation.Text = "-";
            float res = firstNum - secNum;
            resulte.Text = res.ToString();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            operation.Text = "*";
            float res = firstNum * secNum;
            resulte.Text = res.ToString();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            operation.Text = "/";
            float res = firstNum / secNum;
            resulte.Text = res.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            firstNumber.Text = "";
            secondNumber.Text = "";
            resulte.Text = "";
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            Form3 form_ = new Form3();
            form_.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void operation_Click(object sender, EventArgs e)
        {
            
        }

        private void secondNumber_TextChanged(object sender, EventArgs e)
        {
            secNum = float.Parse(secondNumber.Text);
        }

        private void sum_Click(object sender, EventArgs e)
        {
            operation.Text = "+";
            float res = firstNum + secNum;
            resulte.Text = res.ToString();

        }
    }
}
