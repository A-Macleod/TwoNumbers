namespace TwoNumbers
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
            if (disposing && (components != null)) {
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
            this.FirstNumber = new System.Windows.Forms.Button();
            this.SecondNumber = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.IsEqual = new System.Windows.Forms.Button();
            this.GCD = new System.Windows.Forms.Button();
            this.AddNumbers = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Instantiate = new System.Windows.Forms.Button();
            this.ToString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(182, 123);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(75, 23);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.Text = "1st Number";
            this.FirstNumber.UseVisualStyleBackColor = true;
            this.FirstNumber.Click += new System.EventHandler(this.FirstNumber_Click);
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(481, 123);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(75, 23);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.Text = "2nd Number";
            this.SecondNumber.UseVisualStyleBackColor = true;
            this.SecondNumber.Click += new System.EventHandler(this.SecondNumber_Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(106, 193);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(75, 23);
            this.Max.TabIndex = 2;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // IsEqual
            // 
            this.IsEqual.Location = new System.Drawing.Point(217, 193);
            this.IsEqual.Name = "IsEqual";
            this.IsEqual.Size = new System.Drawing.Size(75, 23);
            this.IsEqual.TabIndex = 3;
            this.IsEqual.Text = "Equal";
            this.IsEqual.UseVisualStyleBackColor = true;
            this.IsEqual.Click += new System.EventHandler(this.IsEqual_Click);
            // 
            // GCD
            // 
            this.GCD.Location = new System.Drawing.Point(332, 193);
            this.GCD.Name = "GCD";
            this.GCD.Size = new System.Drawing.Size(75, 23);
            this.GCD.TabIndex = 4;
            this.GCD.Text = "GCD";
            this.GCD.UseVisualStyleBackColor = true;
            this.GCD.Click += new System.EventHandler(this.GCD_Click);
            // 
            // AddNumbers
            // 
            this.AddNumbers.Location = new System.Drawing.Point(440, 193);
            this.AddNumbers.Name = "AddNumbers";
            this.AddNumbers.Size = new System.Drawing.Size(75, 23);
            this.AddNumbers.TabIndex = 5;
            this.AddNumbers.Text = "Add Numbers";
            this.AddNumbers.UseVisualStyleBackColor = true;
            this.AddNumbers.Click += new System.EventHandler(this.AddNumbers_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(456, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 276);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(374, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Instantiate
            // 
            this.Instantiate.Location = new System.Drawing.Point(332, 72);
            this.Instantiate.Name = "Instantiate";
            this.Instantiate.Size = new System.Drawing.Size(75, 23);
            this.Instantiate.TabIndex = 10;
            this.Instantiate.Text = "Instantiate";
            this.Instantiate.UseVisualStyleBackColor = true;
            this.Instantiate.Click += new System.EventHandler(this.Instantiate_Click);
            // 
            // ToString
            // 
            this.ToString.Location = new System.Drawing.Point(548, 193);
            this.ToString.Name = "ToString";
            this.ToString.Size = new System.Drawing.Size(75, 23);
            this.ToString.TabIndex = 12;
            this.ToString.Text = "Display Info";
            this.ToString.UseVisualStyleBackColor = true;
            this.ToString.Click += new System.EventHandler(this.ToString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 389);
            this.Controls.Add(this.ToString);
            this.Controls.Add(this.Instantiate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddNumbers);
            this.Controls.Add(this.GCD);
            this.Controls.Add(this.IsEqual);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Name = "Form1";
            this.Text = "TwoNumbers App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstNumber;
        private System.Windows.Forms.Button SecondNumber;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button IsEqual;
        private System.Windows.Forms.Button GCD;
        private System.Windows.Forms.Button AddNumbers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Instantiate;
        private System.Windows.Forms.Button ToString;
    }
}

