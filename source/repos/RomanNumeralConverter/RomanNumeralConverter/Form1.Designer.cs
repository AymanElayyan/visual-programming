namespace RomanNumeralConverter
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
            this.txt_OrginalNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Converter = new System.Windows.Forms.Button();
            this.lb_RomanicNumber = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_OrginalNumber
            // 
            this.txt_OrginalNumber.Location = new System.Drawing.Point(246, 102);
            this.txt_OrginalNumber.Name = "txt_OrginalNumber";
            this.txt_OrginalNumber.Size = new System.Drawing.Size(144, 26);
            this.txt_OrginalNumber.TabIndex = 0;
            this.txt_OrginalNumber.TextChanged += new System.EventHandler(this.txt_OrginalNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "The number:";
            // 
            // btn_Converter
            // 
            this.btn_Converter.Location = new System.Drawing.Point(205, 213);
            this.btn_Converter.Name = "btn_Converter";
            this.btn_Converter.Size = new System.Drawing.Size(82, 53);
            this.btn_Converter.TabIndex = 2;
            this.btn_Converter.Text = "Convert ";
            this.btn_Converter.UseVisualStyleBackColor = true;
            this.btn_Converter.Click += new System.EventHandler(this.btn_Converter_Click);
            // 
            // lb_RomanicNumber
            // 
            this.lb_RomanicNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_RomanicNumber.Font = new System.Drawing.Font("Bodoni MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RomanicNumber.Location = new System.Drawing.Point(145, 297);
            this.lb_RomanicNumber.Name = "lb_RomanicNumber";
            this.lb_RomanicNumber.Size = new System.Drawing.Size(202, 99);
            this.lb_RomanicNumber.TabIndex = 3;
            this.lb_RomanicNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_RomanicNumber.Click += new System.EventHandler(this.lb_RomanicNumber_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(145, 443);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(76, 40);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "&Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(271, 443);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(76, 40);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "&Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 495);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_RomanicNumber);
            this.Controls.Add(this.btn_Converter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_OrginalNumber);
            this.Name = "Form1";
            this.Text = "Roman Numeral Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_OrginalNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Converter;
        private System.Windows.Forms.Label lb_RomanicNumber;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Exit;
    }
}

