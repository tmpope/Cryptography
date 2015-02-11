using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMethods
{
    public class Primality
    {
        /// <summary>
        /// Tests whether a long > 1 is prime.
        /// </summary>
        /// <param name="l"> An integer > 1 </param>
        /// <returns></returns>
        public bool isPrime(long l)
        {
            if (l % 2 == 0)
                return l == 2;
            return oddIsPrime(l);
        }
        /// <summary>
        /// Tests whether an int > 1 is prime.
        /// </summary>
        /// <param name="l"> An integer > 1 </param>
        /// <returns></returns>
        public bool isPrime(int l)
        {
            if (l % 2 == 0)
                return l == 2;
            return oddIsPrime(l);
        }

        /// <summary>
        /// Tests to see if an odd long is prime.  Will return false positives for
        /// many even values.
        /// </summary>
        /// <param name="l"> An odd integer > 2 </param>
        /// <returns></returns>
        public bool oddIsPrime(long l)
        {
            for (long i = 3; i < Math.Sqrt(l); i += 2)
            {
                if (l % i == 0)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Tests to see if an odd int is prime.  Will return false positives for
        /// many even values.
        /// </summary>
        /// <param name="l"> An odd integer > 2 </param>
        /// <returns></returns>
        public bool oddIsPrime(int l)
        {
            for (int i = 3; i < Math.Sqrt(l); i += 2)
            {
                if (l % i == 0)
                    return false;
            }
            return true;
        }
    }
}