namespace highLanderMap
{
    partial class Directions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Directions));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb1Instruction = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb1Instruction
            // 
            this.lb1Instruction.ForeColor = System.Drawing.Color.Black;
            this.lb1Instruction.Location = new System.Drawing.Point(292, 54);
            this.lb1Instruction.Name = "lb1Instruction";
            this.lb1Instruction.Size = new System.Drawing.Size(237, 37);
            this.lb1Instruction.TabIndex = 2;
            this.lb1Instruction.Text = "Directions to highlander Hotel\r\n";
            this.lb1Instruction.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(202, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 84);
            this.label2.TabIndex = 3;
            this.label2.Text = "Travehng on 89, take Ext 125 South. The hotel is on the 14\r\nTravehg on Rghway 101" +
    " North, the hotel is on the béore\r\nthe 89 ntnection\r\n\r\n";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(145, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Display Direction";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Directions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 754);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1Instruction);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Name = "Directions";
            this.Text = "Directions";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb1Instruction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

