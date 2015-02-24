using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoMethods;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 2387556325;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(CryptoMethods.ModularArithmatic.FastExponentiate(3, a, 38200901201));
                a *= 2;
            }
            Console.WriteLine(CryptoMethods.ModularArithmatic.EuclidianAlgorithm(208, 485));
            long b = 3599;
            Console.WriteLine(CryptoMethods.ModularArithmatic.FastExponentiate(2, (b - 1) / 2, b));
            
            Console.Read();
        }
    }
}
