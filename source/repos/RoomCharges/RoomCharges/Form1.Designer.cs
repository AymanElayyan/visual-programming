namespace RoomCharges
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNightlyCharge = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoomServices = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMisc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbRoomCharges = new System.Windows.Forms.Label();
            this.lbAdditionalCharge = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.lbTotalCharge = new System.Windows.Forms.Label();
            this.btn_CalculateCharge = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btr_exit = new System.Windows.Forms.Button();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highlander Hotel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Today\'s Date:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Brush Script MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.Font = new System.Drawing.Font("Brush Script MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.Location = new System.Drawing.Point(148, 76);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(287, 30);
            this.lblTodayDate.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Brush Script MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(148, 104);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(287, 30);
            this.lblTime.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNightlyCharge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNights);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(30, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 174);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Information";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(56, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nights:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(129, 34);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(115, 26);
            this.txtNights.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-4, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nightly Charge:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNightlyCharge
            // 
            this.txtNightlyCharge.Location = new System.Drawing.Point(129, 80);
            this.txtNightlyCharge.Name = "txtNightlyCharge";
            this.txtNightlyCharge.Size = new System.Drawing.Size(115, 26);
            this.txtNightlyCharge.TabIndex = 6;
            this.txtNightlyCharge.TextChanged += new System.EventHandler(this.txtNightlyCharge_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMisc);
            this.groupBox2.Controls.Add(this.txtTelephone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRoomServices);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(336, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 174);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Charges";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(161, 78);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(115, 26);
            this.txtTelephone.TabIndex = 6;
            this.txtTelephone.TextChanged += new System.EventHandler(this.txtTelephone_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telephone:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomServices
            // 
            this.txtRoomServices.Location = new System.Drawing.Point(161, 34);
            this.txtRoomServices.Name = "txtRoomServices";
            this.txtRoomServices.Size = new System.Drawing.Size(115, 26);
            this.txtRoomServices.TabIndex = 4;
            this.txtRoomServices.TextChanged += new System.EventHandler(this.txtRoomServices_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(17, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 30);
            this.label7.TabIndex = 3;
            this.label7.Text = "Room Services:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMisc
            // 
            this.txtMisc.Location = new System.Drawing.Point(161, 125);
            this.txtMisc.Name = "txtMisc";
            this.txtMisc.Size = new System.Drawing.Size(115, 26);
            this.txtMisc.TabIndex = 7;
            this.txtMisc.TextChanged += new System.EventHandler(this.txtMisc_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(17, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "Misc:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbDiscount);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lbTotalCharge);
            this.groupBox3.Controls.Add(this.lbTax);
            this.groupBox3.Controls.Add(this.lbSubTotal);
            this.groupBox3.Controls.Add(this.lbAdditionalCharge);
            this.groupBox3.Controls.Add(this.lbRoomCharges);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(176, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 327);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Charges";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(17, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "Subtotal:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(-1, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 30);
            this.label10.TabIndex = 5;
            this.label10.Text = "Additional Charge:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(17, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 30);
            this.label11.TabIndex = 3;
            this.label11.Text = "Room Charges:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(17, 197);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(127, 30);
            this.label.TabIndex = 10;
            this.label.Text = "Tax:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(17, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 30);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total Change:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRoomCharges
            // 
            this.lbRoomCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRoomCharges.Location = new System.Drawing.Point(168, 43);
            this.lbRoomCharges.Name = "lbRoomCharges";
            this.lbRoomCharges.Size = new System.Drawing.Size(123, 21);
            this.lbRoomCharges.TabIndex = 13;
            this.lbRoomCharges.Click += new System.EventHandler(this.lbRoomCharges_Click);
            // 
            // lbAdditionalCharge
            // 
            this.lbAdditionalCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAdditionalCharge.Location = new System.Drawing.Point(168, 83);
            this.lbAdditionalCharge.Name = "lbAdditionalCharge";
            this.lbAdditionalCharge.Size = new System.Drawing.Size(123, 21);
            this.lbAdditionalCharge.TabIndex = 14;
            this.lbAdditionalCharge.Click += new System.EventHandler(this.lbAdditionalCharge_Click);
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSubTotal.Location = new System.Drawing.Point(168, 125);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(123, 21);
            this.lbSubTotal.TabIndex = 15;
            this.lbSubTotal.Click += new System.EventHandler(this.lbSubTotal_Click);
            // 
            // lbTax
            // 
            this.lbTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTax.Location = new System.Drawing.Point(168, 201);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(123, 21);
            this.lbTax.TabIndex = 16;
            this.lbTax.Click += new System.EventHandler(this.lbTax_Click);
            // 
            // lbTotalCharge
            // 
            this.lbTotalCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotalCharge.Location = new System.Drawing.Point(168, 250);
            this.lbTotalCharge.Name = "lbTotalCharge";
            this.lbTotalCharge.Size = new System.Drawing.Size(123, 21);
            this.lbTotalCharge.TabIndex = 17;
            this.lbTotalCharge.Click += new System.EventHandler(this.lbTotalCharge_Click);
            // 
            // btn_CalculateCharge
            // 
            this.btn_CalculateCharge.Location = new System.Drawing.Point(175, 694);
            this.btn_CalculateCharge.Name = "btn_CalculateCharge";
            this.btn_CalculateCharge.Size = new System.Drawing.Size(102, 60);
            this.btn_CalculateCharge.TabIndex = 10;
            this.btn_CalculateCharge.Text = "&Calculate Charge";
            this.btn_CalculateCharge.UseVisualStyleBackColor = true;
            this.btn_CalculateCharge.Click += new System.EventHandler(this.btn_CalculateCharge_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(297, 694);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(102, 60);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "clea&r";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btr_exit
            // 
            this.btr_exit.Location = new System.Drawing.Point(419, 694);
            this.btr_exit.Name = "btr_exit";
            this.btr_exit.Size = new System.Drawing.Size(102, 60);
            this.btr_exit.TabIndex = 12;
            this.btr_exit.Text = "Ex&it";
            this.btr_exit.UseVisualStyleBackColor = true;
            this.btr_exit.Click += new System.EventHandler(this.btr_exit_Click);
            // 
            // lbDiscount
            // 
            this.lbDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDiscount.Location = new System.Drawing.Point(168, 155);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(123, 21);
            this.lbDiscount.TabIndex = 19;
            this.lbDiscount.Click += new System.EventHandler(this.lbDiscount_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(17, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 30);
            this.label14.TabIndex = 18;
            this.label14.Text = "Discount:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 805);
            this.Controls.Add(this.btr_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_CalculateCharge);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Room Charge Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNightlyCharge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMisc;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRoomServices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTotalCharge;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label lbAdditionalCharge;
        private System.Windows.Forms.Label lbRoomCharges;
        private System.Windows.Forms.Button btn_CalculateCharge;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btr_exit;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label label14;
    }
}

