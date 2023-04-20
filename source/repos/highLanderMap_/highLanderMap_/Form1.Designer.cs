namespace highLanderMap_
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb1Instruction = new System.Windows.Forms.Label();
            this.lb2DisplayDir = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::highLanderMap_.Properties.Resources.HighlanderHotel_1;
            this.pictureBox1.Location = new System.Drawing.Point(203, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb1Instruction
            // 
            this.lb1Instruction.Location = new System.Drawing.Point(339, 64);
            this.lb1Instruction.Name = "lb1Instruction";
            this.lb1Instruction.Size = new System.Drawing.Size(234, 24);
            this.lb1Instruction.TabIndex = 1;
            this.lb1Instruction.Text = "Directions to highlander Hotel";
            this.lb1Instruction.Click += new System.EventHandler(this.lb1Instruction_Click);
            // 
            // lb2DisplayDir
            // 
            this.lb2DisplayDir.Location = new System.Drawing.Point(232, 513);
            this.lb2DisplayDir.Name = "lb2DisplayDir";
            this.lb2DisplayDir.Size = new System.Drawing.Size(485, 109);
            this.lb2DisplayDir.TabIndex = 2;
            this.lb2DisplayDir.Text = "Travelng on 89, take Exit 125 Suth. The hotel is on the left.\r\nTravelng on Highwa" +
    "y 101 North. the hotel is on the right. Just before the 89 intersedione\r\n\r\n";
            this.lb2DisplayDir.Visible = false;
            this.lb2DisplayDir.Click += new System.EventHandler(this.lb2DisplayDir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Display Directions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Hide";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 719);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb2DisplayDir);
            this.Controls.Add(this.lb1Instruction);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Directions";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb1Instruction;
        private System.Windows.Forms.Label lb2DisplayDir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

