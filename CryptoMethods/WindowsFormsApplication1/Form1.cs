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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            steps = 0;
        }
        private ModularArithmatic mod;
        private long n;
        private int steps;
        private long divisor;
        private long a; //initial choice = a1
        //618240007109027021
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            long.TryParse(textBox1.Text, out n);
            mod = new ModularArithmatic(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            term.Text = steps.ToString();
            if (steps == 0)
            {
                value.Text = "" + (a + 1);
                divisor = ModularArithmatic.GCD(a, n);
            }
            else
            {
                a = mod.FastExponentiate(a, steps);
                value.Text = a.ToString();
                divisor = ModularArithmatic.GCD(a - 1, n);
            }
            gcd.Text = divisor.ToString();
            if(divisor != 0)
                factor.Text = "" + (n / divisor);
            steps++;
        }

        private void initNum_TextChanged(object sender, EventArgs e)
        {
            steps = 0;
            long.TryParse(initNum.Text, out a);
        }
    }
}
