using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtClassA_TS_TextChanged(object sender, EventArgs e)
        {
            txtClassA_TS.Focus();
        }

        private void btnCalculateRe_Click(object sender, EventArgs e)
        {
            try
            {
                int txtClassA = int.Parse(txtClassA_TS.Text) * 15;
                int txtClassB = int.Parse(txtClassB_TS.Text) * 12;
                int txtClassC = int.Parse(txtClassC_TS.Text) * 9;
                lbClassA_RG.Text = txtClassA.ToString("C");
                lbClassB_RG.Text = txtClassB.ToString("C");
                lbClassC_RG.Text = txtClassC.ToString("C");
                lbTotal_RG.Text = (txtClassA + txtClassB + txtClassC).ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtClassA_TS.Text = "";
            txtClassB_TS.Text = "";
            txtClassC_TS.Text = "";
            lbClassA_RG.Text = "";
            lbClassB_RG.Text = "";
            lbClassC_RG.Text = "";
            lbTotal_RG.Text = "";

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
