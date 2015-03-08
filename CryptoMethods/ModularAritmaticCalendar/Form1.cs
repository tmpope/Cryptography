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

namespace ModularAritmaticCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ModularArithmatic mod;
        private void modInput_TextChanged(object sender, EventArgs e)
        {
            long l;
            if (!long.TryParse(modInput.Text, out l))
            {

            }
            mod = new ModularArithmatic(l);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            long a, b;
            long.TryParse(firstNum.Text, out a);
            long.TryParse(secondNum.Text, out b);
            switch (operation.Text)
            {
                case "Fast Exponentiate":
                    answer.Text = "" + mod.FastExponentiate(a, b);
                    break;
                case "GCD":
                    answer.Text = "" + ModularArithmatic.GCD(a, b);
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long a, b;
            long.TryParse(firstNum.Text, out a);
            long.TryParse(secondNum.Text, out b);
            answer.Text = "" + mod.FastExponentiate(a, b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long a, b;
            long.TryParse(firstNumber2.Text, out a);
            long.TryParse(secondNumber2.Text, out b);
            answer2.Text = "" + ModularArithmatic.GCD(a, b);
        }
    }
}
