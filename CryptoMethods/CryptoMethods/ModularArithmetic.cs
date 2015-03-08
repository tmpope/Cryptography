using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CryptoMethods
{
    /// <summary>
    /// Represents a 'coplex' number, an element of 
    /// a + b sqrt(root), where root is not a square mod n.
    /// </summary>
    public class Complex
    {
        private ModularArithmatic mod; // ModularArithmetic(n)
        private long abstractRoot; // not quadratic residue mod n
        public long AbstractRoot
        {
            get { return abstractRoot; }
        }
        private long real;
        public long Real
        {
            get { return real; }
        }
        private long imaginary;
        public long Imaginary
        {
            get { return imaginary; }
        }
        /// <summary>
        /// Assumes abstractRood is not residue in mod. Can be checked externally with Jacobi.
        /// </summary>
        /// <param name="real"></param>
        /// <param name="imaginary"></param>
        /// <param name="abstractRoot"></param>
        /// <param name="mod"></param>
        public Complex(long real, long imaginary, long abstractRoot, ModularArithmatic mod)
        {
            this.mod = mod;
            this.real = real;
            this.imaginary = imaginary;
            this.abstractRoot = abstractRoot;
        }
        /// <summary>
        /// Creates a copy of an existing complex number
        /// </summary>
        /// <param name="c"></param>
        public Complex(Complex c)
        {
            this.real = c.real;
            this.imaginary = c.imaginary;
            this.abstractRoot = c.abstractRoot;
            this.mod = c.mod;
        }
        /// <summary>
        /// Assumes that c1 and c2 are from the same field (i.e. p == p, abstractRoot == abstractRoot)
        /// If this is not the case, return will be as if they were both elements of the c1's field.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.real * c2.real + c1.abstractRoot * c1.imaginary * c2.imaginary,
                c1.real * c2.imaginary + c1.imaginary + c2.real,
                c1.abstractRoot, c1.mod);
        }
        public bool field(Complex c1)
        {
            return abstractRoot == c1.abstractRoot && mod.Mod == c1.mod.Mod;
        }
        public void square()
        {
            long realTemp = real * real + abstractRoot * imaginary * imaginary;
            long imgTemp = real * imaginary * 2;
            real = realTemp;
            imaginary = imgTemp;
        }
        public Complex FastExponentiate(long power)
        {
            string binary = Convert.ToString(power, 2);
            Complex square = new Complex(this);
            Complex answer = new Complex(1, 0, abstractRoot, mod);
            if (binary[binary.Length - 1] == '1')
                answer = this;
            for (int i = 1; i < binary.Length; i++)
            {
                square.square();
                if (binary[binary.Length - 1 - i] == '1')
                    answer = answer * square;
            }
            return answer;
        }
    }
    public class ModularArithmatic
    {
        private long mod;
        public long Mod
        {
            get { return mod; }
        }
        public ModularArithmatic()
        {

        }
        public ModularArithmatic(long mod)
        {
            this.mod = mod;
        }
        /// <summary>
        /// Reduces a long in the field.
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public long Reduce(long l)
        {
            return l % mod;
        }
        /// <summary>
        /// Uses successive squaring to find the bth power of an integer a mod m
        /// </summary>
        /// <param name="a">base</param>
        /// <param name="b">power</param>
        /// <param name="mod">modulus</param>
        /// <returns></returns>
        public long FastExponentiate(long a, long b)
        {
            string binary = Convert.ToString(b, 2);
            BigInteger square = a;
            BigInteger answer = 1;
            if (binary[binary.Length - 1] == '1')
                answer = a;
            for (int i = 1; i < binary.Length; i++)
            {
                square = BigInteger.Pow(square, 2) % mod;
                if (binary[binary.Length - 1 - i] == '1')
                    answer = answer * square % mod;
            }
            return (long)answer;
        }
        public int FastExponentiate(int a, int b)
        {
            return (int)FastExponentiate((long)a, (long)b);
        }
        public static int FastExponentiate(int a, int b, int m)
        {
            ModularArithmatic temp = new ModularArithmatic(m);
            return temp.FastExponentiate(a, b);
        }
        public static long FastExponentiate(long a, long b, long m)
        {
            ModularArithmatic temp = new ModularArithmatic(m);
            return temp.FastExponentiate(a, b);
        }
        /// <summary>
        /// Raises an integer a to a power b mod m 
        /// less efficient version that stores intermediate numbers - 
        /// useful if you need to show work
        /// </summary>
        /// <param name="a">base</param>
        /// <param name="b">power</param>
        /// <param name="m">modulus</param>
        /// <returns></returns>
        public static long FastExponentiate2(long a, long b, long m)
        {
            if (b == 0)
                return 1;
            if (b == 1)
                return a % m;
            string binary = Convert.ToString(b, 2);
            long[] squares = new long[binary.Length];
            squares[0] = a;
            BigInteger temp = new BigInteger();
            for (int i = 1; i < squares.Count(); i++)
            {
                temp = (squares[i - 1]);
                temp = BigInteger.Pow(temp, 2) % m;
                squares[i] = (long)temp;
            }
            temp = 1;
            for (int i = 0; i < squares.Count(); i++)
            {
                if (binary[squares.Count() - 1 - i] == '1')
                {
                    temp = (temp * squares[i]) % m;
                }
            }
            return (long)temp; ;
        }
        /// <summary>
        /// Raises an integer a to a power p mod m.
        /// less efficient version that stores intermediate numbers - 
        /// useful if you need to show work
        /// </summary>
        /// <param name="a">base</param>
        /// <param name="b">power</param>
        /// <param name="m">modulus</param>
        /// <returns></returns>
        public static int FastExponentiate2(int a, int b, int m)
        {
            if (b == 0)
                return 1;
            if (b == 1)
                return a % m;
            string binary = Convert.ToString(b, 2);
            int[] squares = new int[binary.Length];
            squares[0] = a;
            long temp;
            for (int i = 1; i < squares.Count(); i++)
            {
                temp = (squares[i - 1] * squares[i - 1]) % m;
                squares[i] = (int)temp;
            }
            temp = 1;
            for (int i = 0; i < squares.Count(); i++)
            {
                if (binary[squares.Count() - 1 - i] == '1')
                    temp = (temp * squares[i]) % m;
            }
            return (int)temp;
        }
        /// <summary>
        /// Performs the euclidian algorithm on a and b, storing intermediate steps, returns GCD
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long EuclidianAlgorithm(long a, long b)
        {
            int steps = (int)(5 * (1 + Math.Log10(a)));
            long[] dividend = new long[steps];
            long[] quotient = new long[steps];
            dividend[0] = a;
            dividend[1] = b;
            int i = 0;
            do
            {
                quotient[i] = dividend[i] / dividend[i + 1];
                dividend[i + 2] = dividend[i] - quotient[i] * dividend[i + 1];
                i++;
            } while (dividend[i + 1] != 0);
            return dividend[i];
        }
        public static long GCD(long a, long b) {
            if(b == 0)
                return a;
            return GCD(b, a % b);
        }

        /// <summary>
        /// Returns whether a has an inverse modulo mod.  If so, the inverse
        /// is stored in the out variable inverse.  Otherwise the out variable
        /// gets the value 0.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="mod"></param>
        /// <param name="inverse"></param>
        /// <returns></returns>
        public static bool FindInverse2(long a, long mod, out long inverse)
        {
            inverse = 0; //set default value
            //Euclidian algorithm takes at most 5n steps for an n-digit number
            int steps = (int)(5 * (1 + Math.Log10(mod)));
            long[] dividend = new long[steps]; //keep track to find inverse
            long[] quotient = new long[steps];
            dividend[0] = mod;
            dividend[1] = a;
            int i = 0;
            do
            {
                quotient[i] = dividend[i] / dividend[i + 1];
                dividend[i + 2] = dividend[i] - quotient[i] * dividend[i + 1];
                i++;
            } while (dividend[i + 1] != 0);
            if (dividend[i] != 1)
                return false;
            //TODO find inverse by traversing steps of Euclidian Algorithm
            return true;
        }
        /// <summary>
        /// Finds the Jacobi symbol (a/b), which is either +/- 1, or 0 if a = 0 mod b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Jacobi(long a, long b) {
            if (a % b == 0)
                return 0;
            if(a < 0) 
            {
                if((b & 3) == 3)
                    return -1 * (Jacobi(-1 * a, b));
                return (Jacobi(-1 * a, b));
            }
            if (a == 2)
            {
                switch (b % 8)
                {
                    case 3:
                    case 5:
                        return -1;
                    case 1:
                    case 7:
                        return 1;
                }
            }
            if(a > b)
                return Jacobi(a % b, b);
            return 0;//TODO finish implementing
        }
        public int Jacobi(long a)
        {
            return Jacobi(a, mod);
        }
        /// <summary>
        /// Calculates the Legendre symbol of a mod p.  Assumes p is prime.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Legendre(long a)
        {
            if (a > mod)
                a = a % mod;
            if (a == 0)
                return 0;
            return (int) FastExponentiate(a, (mod - 1) / 2);
        }
        /// <summary>
        /// Returns whether a has an inverse modulo mod.  If so, the inverse
        /// is stored in the out variable inverse.  Otherwise the out variable
        /// will be a zero divisor that pairs with number.
        /// </summary>
        /// <param name="number">the number to find the inverse of</param>
        /// <param name="mod">the modulus</param>
        /// <param name="inverse">stores the inverse</param>
        /// <returns></returns>
        public static bool FindInverse(long number, long mod, out long inverse)
        {
            // I realize this is utterly unreadable - I spent several hours with paper
            // and pencil working it out.  But it worked on paper, and worked right away the first
            // time I tried it.  
            // The starting idea was the euclidian algorithm, except each time
            // the remainder was calculated in terms of the first two numbers
            // The traditional long-hand way to calculate an inverse modulo mod is to perform the 
            // euclidian algorithm, giving you
            // mod      = q1 * number + r1
            // number   = q2 * r1 + r2
            // r1       = q3 * r2 + r3
            // ri       = qi+2 * ri+1 + ri+2
            // which is continued until ri+2 = 1
            // Then the nubmers of the algorithm are traversed in reverse, starting with
            // 1 = ri - qi+2 * ri+1
            // and substituting in 
            // ri+1 = ri-1 - qi+1 * ri
            // until all the r terms have been eliminated, leaving you with
            // 1 = d * mod + e * number
            // where e will be number's inverse modulo mod.
            // However, instead of performing the euclidian algorithm and traversing it in 
            // reverse order, the code finds each successive remainder as a linear combination
            // of mod and number, and keeps track of the coefficients for two remainders
            // to calculate the coefficients for the third, then moves on until the remainder
            // is 1, in which case the coefficient of number is its inverse modulo mod
            // in general through the method:
            // ri = b * mod + c * number
            // ri+1 = d * mod + e * number
            // q = ri / ri+1 (integer division)
            // ri+2 = f * mod + g * number
            long b = 1; //r1 = 1 * mod - (mod / number) * number
            long c = -1 * mod / number;
            if (b * mod + c * number == 0) //if number divides mod, then it clearly has no inverse
            { //this avoids dividing by 0 in setting d
                inverse = -1 * c % mod;
                return false;
            }
            //r2 = number - (number / r1) r1
            long d = (number / (b * mod + c * number));
            long e = 1 + (mod / number) * (number / (b * mod + c * number));
            long f, g, q; //temp variables to compute ri+2 without changing ri or ri+1
            while (d * mod + e * number > 1)
            {//if the remainder is less than or equal to 1, it is either 1, (the inverse is found),
                //or it is 0 (no inverse exists)
                q = (b * mod + c * number) / (d * mod + e * number);
                //compute new coefficients
                f = b - q * d;
                g = c - q * e;
                //overwrite old pair with new pair
                b = d;
                c = e;
                d = f;
                e = g;
            }
            // e is equivalent to the inverse modulo mod
            inverse = e % mod;
            return (d * mod + e * number == 1);
        }
    }
}