namespace Sale_Price_Calculator
{
    partial class Form2
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
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.resulte = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.nextForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumber
            // 
            this.firstNumber.Location = new System.Drawing.Point(50, 93);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(100, 26);
            this.firstNumber.TabIndex = 0;
            this.firstNumber.TextChanged += new System.EventHandler(this.firstNumber_TextChanged);
            // 
            // secondNumber
            // 
            this.secondNumber.Location = new System.Drawing.Point(229, 93);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(100, 26);
            this.secondNumber.TabIndex = 1;
            this.secondNumber.TextChanged += new System.EventHandler(this.secondNumber_TextChanged);
            // 
            // resulte
            // 
            this.resulte.Location = new System.Drawing.Point(369, 96);
            this.resulte.Name = "resulte";
            this.resulte.Size = new System.Drawing.Size(100, 26);
            this.resulte.TabIndex = 2;
            this.resulte.TextChanged += new System.EventHandler(this.resulte_TextChanged);
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Location = new System.Drawing.Point(156, 93);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(76, 20);
            this.operation.TabIndex = 3;
            this.operation.Text = "operation";
            this.operation.Click += new System.EventHandler(this.operation_Click);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(335, 99);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(18, 20);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(50, 226);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(51, 57);
            this.sum.TabIndex = 5;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(126, 226);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(51, 57);
            this.Subtract.TabIndex = 6;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(202, 226);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(51, 57);
            this.multiplication.TabIndex = 7;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(278, 226);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(51, 57);
            this.Division.TabIndex = 8;
            this.Division.Text = "\\";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(514, 188);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(105, 43);
            this.clear.TabIndex = 9;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(514, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 43);
            this.button6.TabIndex = 10;
            this.button6.Text = "close";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // nextForm
            // 
            this.nextForm.Location = new System.Drawing.Point(514, 315);
            this.nextForm.Name = "nextForm";
            this.nextForm.Size = new System.Drawing.Size(105, 41);
            this.nextForm.TabIndex = 11;
            this.nextForm.Text = "Next Form";
            this.nextForm.UseVisualStyleBackColor = true;
            this.nextForm.Click += new System.EventHandler(this.nextForm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 368);
            this.Controls.Add(this.nextForm);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.resulte);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.firstNumber);
            this.Name = "Form2";
            this.Text = "Basic_Arithmetic_Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.TextBox secondNumber;
        private System.Windows.Forms.TextBox resulte;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button nextForm;
    }
}