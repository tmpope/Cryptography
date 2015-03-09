using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoMethods;

namespace P_1Factor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Complex c;
        private long n;
        private long real;
        private long imaginary;
        private long abstractRoot;
        private int steps;
        private long divisor;
        private void nBox_TextChanged(object sender, EventArgs e)
        {
            long.TryParse(nBox.Text, out n);
            steps = 0;
            c = new Complex(real, imaginary, abstractRoot, new ModularArithmatic(n));
        }
        private void realBox_TextChanged(object sender, EventArgs e)
        {
            long.TryParse(realBox.Text, out real);
            steps = 0;
            c = new Complex(real, imaginary, abstractRoot, new ModularArithmatic(n));
        }
        private void imaginaryBox_TextChanged(object sender, EventArgs e)
        {
            long.TryParse(imaginaryBox.Text, out imaginary);
            steps = 0;
            c = new Complex(real, imaginary, abstractRoot, new ModularArithmatic(n));
        }

        private void rootBox_TextChanged(object sender, EventArgs e)
        {
            long.TryParse(rootBox.Text, out abstractRoot);
            steps = 0;
            c = new Complex(real, imaginary, abstractRoot, new ModularArithmatic(n));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            termBox.Text = steps.ToString();
            if (steps == 0)
            {
                valueBox.Text = "" + c.Norm.ToString();
                divisor = ModularArithmatic.GCD(c.Norm, n);
            }
            else
            {
                c = c.FastExponentiate(steps);
                valueBox.Text = c.ToString();
                divisor = ModularArithmatic.GCD(c.Imaginary, n);
            }
            gcdBox.Text = divisor.ToString();
            if (divisor != 0)
                factorBox.Text = "" + (n / divisor);
            steps++;
        }

    }
}
