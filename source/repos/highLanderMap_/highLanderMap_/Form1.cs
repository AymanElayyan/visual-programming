using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace highLanderMap_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb1Instruction_Click(object sender, EventArgs e)
        {

        }

        private void lb2DisplayDir_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lb2DisplayDir.Visible = true;
            lb2DisplayDir.Text = "Travelng on 89, take Exit 125 Suth. The hotel is on the left.\r\nTravelng on Highway 101 North. the hotel is on the right. Just before\r\nthe 89 intersedione\r\n\r\n";
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes )
                 this.lb2DisplayDir.Visible = false;
            else
                 this.lb2DisplayDir.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.lb2DisplayDir.Visible = true;
            lb2DisplayDir.Text = "Travelng on 89, take Exit 125 Suth. The hotel is on the left.\r\nTravelng on Highway 101 North. the hotel is on the right. Just before\r\nthe 89 intersedione\r\n\r\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
