namespace VehicleLoanCalculator
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
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NumberOfMonths = new System.Windows.Forms.TextBox();
            this.txt_AmountOfDownPayment = new System.Windows.Forms.TextBox();
            this.txt_CostOfVehicle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_Used = new System.Windows.Forms.RadioButton();
            this.rad_New = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_AnnualInterestRate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Calculator = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NumberOfMonths);
            this.groupBox1.Controls.Add(this.txt_AmountOfDownPayment);
            this.groupBox1.Controls.Add(this.txt_CostOfVehicle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle and Loan Infomation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_NumberOfMonths
            // 
            this.txt_NumberOfMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumberOfMonths.Location = new System.Drawing.Point(244, 125);
            this.txt_NumberOfMonths.Name = "txt_NumberOfMonths";
            this.txt_NumberOfMonths.Size = new System.Drawing.Size(162, 26);
            this.txt_NumberOfMonths.TabIndex = 5;
            // 
            // txt_AmountOfDownPayment
            // 
            this.txt_AmountOfDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AmountOfDownPayment.Location = new System.Drawing.Point(244, 80);
            this.txt_AmountOfDownPayment.Name = "txt_AmountOfDownPayment";
            this.txt_AmountOfDownPayment.Size = new System.Drawing.Size(162, 26);
            this.txt_AmountOfDownPayment.TabIndex = 4;
            // 
            // txt_CostOfVehicle
            // 
            this.txt_CostOfVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CostOfVehicle.Location = new System.Drawing.Point(244, 37);
            this.txt_CostOfVehicle.Name = "txt_CostOfVehicle";
            this.txt_CostOfVehicle.Size = new System.Drawing.Size(162, 26);
            this.txt_CostOfVehicle.TabIndex = 3;
            this.txt_CostOfVehicle.TextChanged += new System.EventHandler(this.txt_CostOfVehicle_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Months:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount of Down Payment:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost of Vehicle:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_Used);
            this.groupBox2.Controls.Add(this.rad_New);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(523, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 200);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New or Used?";
            // 
            // rad_Used
            // 
            this.rad_Used.AutoSize = true;
            this.rad_Used.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Used.Location = new System.Drawing.Point(43, 96);
            this.rad_Used.Name = "rad_Used";
            this.rad_Used.Size = new System.Drawing.Size(72, 24);
            this.rad_Used.TabIndex = 3;
            this.rad_Used.TabStop = true;
            this.rad_Used.Text = "Used";
            this.rad_Used.UseVisualStyleBackColor = true;
            // 
            // rad_New
            // 
            this.rad_New.AutoSize = true;
            this.rad_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_New.Location = new System.Drawing.Point(43, 49);
            this.rad_New.Name = "rad_New";
            this.rad_New.Size = new System.Drawing.Size(65, 24);
            this.rad_New.TabIndex = 2;
            this.rad_New.TabStop = true;
            this.rad_New.Text = "New";
            this.rad_New.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Annual Interest Rate:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_AnnualInterestRate
            // 
            this.lbl_AnnualInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_AnnualInterestRate.Location = new System.Drawing.Point(807, 118);
            this.lbl_AnnualInterestRate.Name = "lbl_AnnualInterestRate";
            this.lbl_AnnualInterestRate.Size = new System.Drawing.Size(133, 27);
            this.lbl_AnnualInterestRate.TabIndex = 6;
            this.lbl_AnnualInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(30, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(968, 357);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "It-derest and Prncipal Payments";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(19, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(925, 304);
            this.listBox1.TabIndex = 0;
            // 
            // btn_Calculator
            // 
            this.btn_Calculator.Location = new System.Drawing.Point(289, 664);
            this.btn_Calculator.Name = "btn_Calculator";
            this.btn_Calculator.Size = new System.Drawing.Size(112, 52);
            this.btn_Calculator.TabIndex = 8;
            this.btn_Calculator.Text = "&Calculate";
            this.btn_Calculator.UseVisualStyleBackColor = true;
            this.btn_Calculator.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(456, 664);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(112, 52);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(626, 664);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(112, 52);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1023, 736);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculator);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_AnnualInterestRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Loan Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NumberOfMonths;
        private System.Windows.Forms.TextBox txt_AmountOfDownPayment;
        private System.Windows.Forms.TextBox txt_CostOfVehicle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_Used;
        private System.Windows.Forms.RadioButton rad_New;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_AnnualInterestRate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Calculator;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
    }
}

