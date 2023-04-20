using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomCharges
{
    public partial class Form1 : Form
    {
        float addCharge, nightsInput, results;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTodayDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void txtMisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbRoomCharges_Click(object sender, EventArgs e)
        {
            

        }

        private void txtNightlyCharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbAdditionalCharge_Click(object sender, EventArgs e)
        {
           
        }

        private void txtRoomServices_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTax_Click(object sender, EventArgs e)
        {
            
        }

        private void lbDiscount_Click(object sender, EventArgs e)
        {
         
                

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtNights.Text = "";
            txtNightlyCharge.Text = "";
            txtRoomServices.Text = "";
            txtTelephone.Text = "";
            txtMisc.Text = "";
            lbRoomCharges.Text = "";
            lbAdditionalCharge.Text = "";
            lbSubTotal.Text = "";
            lbTotalCharge.Text = "";
            lbDiscount.Text = "";
            lbTax.Text = "";
                 
        }

        private void btr_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CalculateCharge_Click(object sender, EventArgs e)
        {
            
                nightsInput = float.Parse(txtNights.Text) * float.Parse(txtNightlyCharge.Text);
                lbRoomCharges.Text = nightsInput.ToString("C");
                addCharge = float.Parse(txtRoomServices.Text) + float.Parse(txtTelephone.Text) + float.Parse(txtMisc.Text);
                lbAdditionalCharge.Text = addCharge.ToString("C");
                results = addCharge + nightsInput;
                lbSubTotal.Text = results.ToString("C");
                int i = int.Parse(txtNights.Text);
                lbTax.Text = 33.70.ToString("C");
                float result_ = results + 33.70f;
                lbTotalCharge.Text = result_.ToString("C");
                if (i >= 10)
                {
                    lbDiscount.Text = (results * 0.1).ToString("C");
                }
                else
                {
                    lbDiscount.Text = (results * 0.3).ToString("C");
                }
            
            
        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTotalCharge_Click(object sender, EventArgs e)
        {
            
        }

        private void lbSubTotal_Click(object sender, EventArgs e)
        {
           
        }
    }
}
