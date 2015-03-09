namespace P_1Factor
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
            this.label1 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.realBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imaginaryBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rootBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.termBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gcdBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.factorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number to Factor";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(107, 46);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 20);
            this.nBox.TabIndex = 1;
            this.nBox.TextChanged += new System.EventHandler(this.nBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Real";
            // 
            // realBox
            // 
            this.realBox.Location = new System.Drawing.Point(248, 46);
            this.realBox.Name = "realBox";
            this.realBox.Size = new System.Drawing.Size(100, 20);
            this.realBox.TabIndex = 3;
            this.realBox.TextChanged += new System.EventHandler(this.realBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imaginary";
            // 
            // imaginaryBox
            // 
            this.imaginaryBox.Location = new System.Drawing.Point(412, 46);
            this.imaginaryBox.Name = "imaginaryBox";
            this.imaginaryBox.Size = new System.Drawing.Size(100, 20);
            this.imaginaryBox.TabIndex = 5;
            this.imaginaryBox.TextChanged += new System.EventHandler(this.imaginaryBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Abstract Root";
            // 
            // rootBox
            // 
            this.rootBox.Location = new System.Drawing.Point(596, 46);
            this.rootBox.Name = "rootBox";
            this.rootBox.Size = new System.Drawing.Size(100, 20);
            this.rootBox.TabIndex = 7;
            this.rootBox.TextChanged += new System.EventHandler(this.rootBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Next Step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Term Number";
            // 
            // termBox
            // 
            this.termBox.Location = new System.Drawing.Point(69, 149);
            this.termBox.Name = "termBox";
            this.termBox.Size = new System.Drawing.Size(100, 20);
            this.termBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Value";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(219, 149);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(100, 20);
            this.valueBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "gcd(Im(term), n)";
            // 
            // gcdBox
            // 
            this.gcdBox.Location = new System.Drawing.Point(412, 149);
            this.gcdBox.Name = "gcdBox";
            this.gcdBox.Size = new System.Drawing.Size(100, 20);
            this.gcdBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Factor";
            // 
            // factorBox
            // 
            this.factorBox.Location = new System.Drawing.Point(596, 242);
            this.factorBox.Name = "factorBox";
            this.factorBox.Size = new System.Drawing.Size(100, 20);
            this.factorBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 316);
            this.Controls.Add(this.factorBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gcdBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.termBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rootBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imaginaryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.realBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "P + 1 Factoring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox realBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imaginaryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rootBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox termBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gcdBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox factorBox;
    }
}

