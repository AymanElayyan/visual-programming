namespace MembershipFee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radAduIt = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTrainer = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblMonthIyFee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSenior);
            this.groupBox1.Controls.Add(this.radStudent);
            this.groupBox1.Controls.Add(this.radChild);
            this.groupBox1.Controls.Add(this.radAduIt);
            this.groupBox1.Location = new System.Drawing.Point(54, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Membership";
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(18, 128);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(132, 24);
            this.radSenior.TabIndex = 3;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "Senior Citizen";
            this.radSenior.UseVisualStyleBackColor = true;
            this.radSenior.CheckedChanged += new System.EventHandler(this.radSenior_CheckedChanged);
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(18, 98);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(91, 24);
            this.radStudent.TabIndex = 2;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            this.radStudent.CheckedChanged += new System.EventHandler(this.radStudent_CheckedChanged);
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(18, 68);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(177, 24);
            this.radChild.TabIndex = 1;
            this.radChild.TabStop = true;
            this.radChild.Text = "Child (12 and under)";
            this.radChild.UseVisualStyleBackColor = true;
            this.radChild.CheckedChanged += new System.EventHandler(this.radChild_CheckedChanged);
            // 
            // radAduIt
            // 
            this.radAduIt.AutoSize = true;
            this.radAduIt.Location = new System.Drawing.Point(18, 38);
            this.radAduIt.Name = "radAduIt";
            this.radAduIt.Size = new System.Drawing.Size(141, 24);
            this.radAduIt.TabIndex = 0;
            this.radAduIt.TabStop = true;
            this.radAduIt.Text = "Standard Adult";
            this.radAduIt.UseVisualStyleBackColor = true;
            this.radAduIt.CheckedChanged += new System.EventHandler(this.radAduIt_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTrainer);
            this.groupBox2.Controls.Add(this.chkKarate);
            this.groupBox2.Controls.Add(this.chkYoga);
            this.groupBox2.Location = new System.Drawing.Point(374, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // chkTrainer
            // 
            this.chkTrainer.AutoSize = true;
            this.chkTrainer.Location = new System.Drawing.Point(20, 120);
            this.chkTrainer.Name = "chkTrainer";
            this.chkTrainer.Size = new System.Drawing.Size(150, 24);
            this.chkTrainer.TabIndex = 2;
            this.chkTrainer.Text = "Personal Trainer";
            this.chkTrainer.UseVisualStyleBackColor = true;
            this.chkTrainer.CheckedChanged += new System.EventHandler(this.chkTrainer_CheckedChanged);
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(20, 80);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(82, 24);
            this.chkKarate.TabIndex = 1;
            this.chkKarate.Text = "Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            this.chkKarate.CheckedChanged += new System.EventHandler(this.chkKarate_CheckedChanged);
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(20, 38);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(73, 24);
            this.chkYoga.TabIndex = 0;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            this.chkYoga.CheckedChanged += new System.EventHandler(this.chkYoga_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMonths);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(54, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Membership Length";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(27, 89);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(145, 26);
            this.txtMonths.TabIndex = 1;
            this.txtMonths.TextChanged += new System.EventHandler(this.txtMonths_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Number of Months:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalFee);
            this.groupBox4.Controls.Add(this.lblMonthIyFee);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(374, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 144);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Membership Fees";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFee.Location = new System.Drawing.Point(126, 89);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(104, 26);
            this.lblTotalFee.TabIndex = 5;
            this.lblTotalFee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotalFee.Click += new System.EventHandler(this.lblTotalFee_Click);
            // 
            // lblMonthIyFee
            // 
            this.lblMonthIyFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthIyFee.Location = new System.Drawing.Point(126, 39);
            this.lblMonthIyFee.Name = "lblMonthIyFee";
            this.lblMonthIyFee.Size = new System.Drawing.Size(104, 26);
            this.lblMonthIyFee.TabIndex = 4;
            this.lblMonthIyFee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monthly Fee:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(162, 437);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 40);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(293, 437);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(428, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 538);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Membership Fee Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radAduIt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTrainer;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label lblMonthIyFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

