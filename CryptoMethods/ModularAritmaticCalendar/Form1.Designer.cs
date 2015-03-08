namespace ModularAritmaticCalendar
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
            this.modInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secondNum = new System.Windows.Forms.TextBox();
            this.firstNum = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.answer2 = new System.Windows.Forms.TextBox();
            this.firstNumber2 = new System.Windows.Forms.TextBox();
            this.secondNumber2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.operation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // modInput
            // 
            this.modInput.Location = new System.Drawing.Point(487, 49);
            this.modInput.Name = "modInput";
            this.modInput.Size = new System.Drawing.Size(100, 20);
            this.modInput.TabIndex = 0;
            this.modInput.TextChanged += new System.EventHandler(this.modInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mod N";
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(320, 49);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(100, 20);
            this.secondNum.TabIndex = 2;
            // 
            // firstNum
            // 
            this.firstNum.Location = new System.Drawing.Point(57, 49);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(100, 20);
            this.firstNum.TabIndex = 3;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(487, 146);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(100, 20);
            this.answer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Input first number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Input second number";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(487, 87);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Input second number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Input first number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Answer";
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(487, 343);
            this.answer2.Name = "answer2";
            this.answer2.ReadOnly = true;
            this.answer2.Size = new System.Drawing.Size(100, 20);
            this.answer2.TabIndex = 16;
            // 
            // firstNumber2
            // 
            this.firstNumber2.Location = new System.Drawing.Point(57, 246);
            this.firstNumber2.Name = "firstNumber2";
            this.firstNumber2.Size = new System.Drawing.Size(100, 20);
            this.firstNumber2.TabIndex = 14;
            // 
            // secondNumber2
            // 
            this.secondNumber2.Location = new System.Drawing.Point(320, 246);
            this.secondNumber2.Name = "secondNumber2";
            this.secondNumber2.Size = new System.Drawing.Size(100, 20);
            this.secondNumber2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Fast Exponentiate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "GCD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Operation";
            // 
            // operation
            // 
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            "Fast Exponentiate",
            "GCD"});
            this.operation.Location = new System.Drawing.Point(178, 48);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(121, 21);
            this.operation.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 413);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.firstNumber2);
            this.Controls.Add(this.secondNumber2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secondNum;
        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox answer2;
        private System.Windows.Forms.TextBox firstNumber2;
        private System.Windows.Forms.TextBox secondNumber2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox operation;
    }
}

