namespace Sale_Price_Calculator
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
            this.originalPricePromptLabel = new System.Windows.Forms.Label();
            this.discPercentagePromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabeI = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.nextForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalPricePromptLabel
            // 
            this.originalPricePromptLabel.AutoSize = true;
            this.originalPricePromptLabel.Location = new System.Drawing.Point(110, 56);
            this.originalPricePromptLabel.Name = "originalPricePromptLabel";
            this.originalPricePromptLabel.Size = new System.Drawing.Size(216, 20);
            this.originalPricePromptLabel.TabIndex = 0;
            this.originalPricePromptLabel.Text = "Enter the item\'s original price:";
            this.originalPricePromptLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // discPercentagePromptLabel
            // 
            this.discPercentagePromptLabel.AutoSize = true;
            this.discPercentagePromptLabel.Location = new System.Drawing.Point(110, 107);
            this.discPercentagePromptLabel.Name = "discPercentagePromptLabel";
            this.discPercentagePromptLabel.Size = new System.Drawing.Size(228, 20);
            this.discPercentagePromptLabel.TabIndex = 1;
            this.discPercentagePromptLabel.Text = "Enter the discount percentage:";
            this.discPercentagePromptLabel.Click += new System.EventHandler(this.discPercentagePromptLabel_Click);
            // 
            // outputDescriptionLabeI
            // 
            this.outputDescriptionLabeI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDescriptionLabeI.Location = new System.Drawing.Point(188, 177);
            this.outputDescriptionLabeI.Name = "outputDescriptionLabeI";
            this.outputDescriptionLabeI.Size = new System.Drawing.Size(228, 30);
            this.outputDescriptionLabeI.TabIndex = 2;
            this.outputDescriptionLabeI.Text = "sale price:";
            this.outputDescriptionLabeI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputDescriptionLabeI.Click += new System.EventHandler(this.label3_Click);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(435, 56);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(209, 26);
            this.PriceTextBox.TabIndex = 3;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.Location = new System.Drawing.Point(435, 107);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.Size = new System.Drawing.Size(209, 26);
            this.discountPercentageTextBox.TabIndex = 4;
            this.discountPercentageTextBox.TextChanged += new System.EventHandler(this.discountPercentageTextBox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(223, 329);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(115, 59);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate sale price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(469, 329);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 59);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salePriceLabel.Location = new System.Drawing.Point(435, 177);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(215, 30);
            this.salePriceLabel.TabIndex = 8;
            this.salePriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.salePriceLabel.Click += new System.EventHandler(this.salePriceLabel_Click);
            // 
            // nextForm
            // 
            this.nextForm.Location = new System.Drawing.Point(683, 380);
            this.nextForm.Name = "nextForm";
            this.nextForm.Size = new System.Drawing.Size(96, 58);
            this.nextForm.TabIndex = 9;
            this.nextForm.Text = "next form";
            this.nextForm.UseVisualStyleBackColor = true;
            this.nextForm.Click += new System.EventHandler(this.nextForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextForm);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.discountPercentageTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.outputDescriptionLabeI);
            this.Controls.Add(this.discPercentagePromptLabel);
            this.Controls.Add(this.originalPricePromptLabel);
            this.Name = "Form1";
            this.Text = "Sale Price Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalPricePromptLabel;
        private System.Windows.Forms.Label discPercentagePromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabeI;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox discountPercentageTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.Button nextForm;
    }
}

