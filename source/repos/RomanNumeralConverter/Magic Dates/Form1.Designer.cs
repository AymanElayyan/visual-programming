namespace Magic_Dates
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
            this.txt_Day = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.btn_Magic = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Day
            // 
            this.txt_Day.Location = new System.Drawing.Point(190, 44);
            this.txt_Day.Name = "txt_Day";
            this.txt_Day.Size = new System.Drawing.Size(96, 26);
            this.txt_Day.TabIndex = 0;
            this.txt_Day.TextChanged += new System.EventHandler(this.txt_Day_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Day:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(190, 91);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(96, 26);
            this.txt_month.TabIndex = 6;
            this.txt_month.TextChanged += new System.EventHandler(this.txt_month_TextChanged);
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(190, 138);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(96, 26);
            this.txt_year.TabIndex = 7;
            this.txt_year.TextChanged += new System.EventHandler(this.txt_year_TextChanged);
            // 
            // btn_Magic
            // 
            this.btn_Magic.Location = new System.Drawing.Point(347, 88);
            this.btn_Magic.Name = "btn_Magic";
            this.btn_Magic.Size = new System.Drawing.Size(111, 37);
            this.btn_Magic.TabIndex = 8;
            this.btn_Magic.Text = "&Magic Day ?";
            this.btn_Magic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Magic.UseVisualStyleBackColor = true;
            this.btn_Magic.Click += new System.EventHandler(this.btn_Magic_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(173, 235);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(86, 34);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "&Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(296, 235);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 34);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 296);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Magic);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.txt_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Day);
            this.Name = "Form1";
            this.Text = "Magic Dates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Button btn_Magic;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
    }
}

