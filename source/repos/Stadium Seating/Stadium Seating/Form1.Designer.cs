namespace Stadium_Seating
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
            this.txtClassC_TS = new System.Windows.Forms.TextBox();
            this.txtClassB_TS = new System.Windows.Forms.TextBox();
            this.txtClassA_TS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTotal_RG = new System.Windows.Forms.Label();
            this.lbClassC_RG = new System.Windows.Forms.Label();
            this.lbClassB_RG = new System.Windows.Forms.Label();
            this.lbClassA_RG = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalculateRe = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClassC_TS);
            this.groupBox1.Controls.Add(this.txtClassB_TS);
            this.groupBox1.Controls.Add(this.txtClassA_TS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // txtClassC_TS
            // 
            this.txtClassC_TS.Location = new System.Drawing.Point(152, 224);
            this.txtClassC_TS.Name = "txtClassC_TS";
            this.txtClassC_TS.Size = new System.Drawing.Size(178, 30);
            this.txtClassC_TS.TabIndex = 6;
            // 
            // txtClassB_TS
            // 
            this.txtClassB_TS.Location = new System.Drawing.Point(152, 167);
            this.txtClassB_TS.Name = "txtClassB_TS";
            this.txtClassB_TS.Size = new System.Drawing.Size(178, 30);
            this.txtClassB_TS.TabIndex = 5;
            // 
            // txtClassA_TS
            // 
            this.txtClassA_TS.Location = new System.Drawing.Point(152, 108);
            this.txtClassA_TS.Name = "txtClassA_TS";
            this.txtClassA_TS.Size = new System.Drawing.Size(178, 30);
            this.txtClassA_TS.TabIndex = 4;
            this.txtClassA_TS.TextChanged += new System.EventHandler(this.txtClassA_TS_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(33, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(88, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold for each class of seats.\r\n\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTotal_RG);
            this.groupBox2.Controls.Add(this.lbClassC_RG);
            this.groupBox2.Controls.Add(this.lbClassB_RG);
            this.groupBox2.Controls.Add(this.lbClassA_RG);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(416, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 367);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue Generated";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbTotal_RG
            // 
            this.lbTotal_RG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal_RG.Location = new System.Drawing.Point(140, 279);
            this.lbTotal_RG.Name = "lbTotal_RG";
            this.lbTotal_RG.Size = new System.Drawing.Size(170, 31);
            this.lbTotal_RG.TabIndex = 11;
            this.lbTotal_RG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbClassC_RG
            // 
            this.lbClassC_RG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbClassC_RG.Location = new System.Drawing.Point(140, 222);
            this.lbClassC_RG.Name = "lbClassC_RG";
            this.lbClassC_RG.Size = new System.Drawing.Size(170, 31);
            this.lbClassC_RG.TabIndex = 10;
            this.lbClassC_RG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbClassB_RG
            // 
            this.lbClassB_RG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbClassB_RG.Location = new System.Drawing.Point(140, 169);
            this.lbClassB_RG.Name = "lbClassB_RG";
            this.lbClassB_RG.Size = new System.Drawing.Size(170, 31);
            this.lbClassB_RG.TabIndex = 9;
            this.lbClassB_RG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbClassA_RG
            // 
            this.lbClassA_RG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbClassA_RG.Location = new System.Drawing.Point(140, 116);
            this.lbClassA_RG.Name = "lbClassA_RG";
            this.lbClassA_RG.Size = new System.Drawing.Size(170, 31);
            this.lbClassA_RG.TabIndex = 8;
            this.lbClassA_RG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(33, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 31);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(33, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Class C :";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(33, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Class B :";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(33, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Class A :";
            // 
            // btnCalculateRe
            // 
            this.btnCalculateRe.Location = new System.Drawing.Point(189, 493);
            this.btnCalculateRe.Name = "btnCalculateRe";
            this.btnCalculateRe.Size = new System.Drawing.Size(121, 78);
            this.btnCalculateRe.TabIndex = 8;
            this.btnCalculateRe.Text = "&Calculate Revenue";
            this.btnCalculateRe.UseVisualStyleBackColor = true;
            this.btnCalculateRe.Click += new System.EventHandler(this.btnCalculateRe_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(349, 493);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(121, 78);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clea&r";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(504, 493);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 78);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 668);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btnCalculateRe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClassC_TS;
        private System.Windows.Forms.TextBox txtClassB_TS;
        private System.Windows.Forms.TextBox txtClassA_TS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculateRe;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label lbTotal_RG;
        private System.Windows.Forms.Label lbClassC_RG;
        private System.Windows.Forms.Label lbClassB_RG;
        private System.Windows.Forms.Label lbClassA_RG;
    }
}

