using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CryptoMethods;

namespace CryptoTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, CryptoMethods.ModularArithmatic.FastExponentiate(1, 1, 2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1024, CryptoMethods.ModularArithmatic.FastExponentiate(2, 10, 10000));
        }
        [TestMethod]
        public void TestMethod3()
        {
            long a = 8059008699;
            long b = 5448013423;
            long m = 10993522499;
            Assert.AreEqual(821, CryptoMethods.ModularArithmatic.FastExponentiate(83, 11, 1517));
        }
        [TestMethod]
        public void TestMethod3b()
        {
            long a = 8059008699;
            long b = 5448013423;
            long m = 10993522499;
            Assert.AreEqual(1097, CryptoMethods.ModularArithmatic.FastExponentiate(72, 11, 1517));
        }
        [TestMethod]
        public void TestMethod4()
        {
            long a = 2;
            Assert.AreEqual(1024, CryptoMethods.ModularArithmatic.FastExponentiate(a, 10, 10000));
        }

        [TestMethod]
        public void TestMethod5()
        {
            int a = 2;
            Assert.AreEqual(1, CryptoMethods.ModularArithmatic.FastExponentiate(a, 10, 1023));
        }
        [TestMethod]
        public void TestMethod6()
        {
            long a = 576031280;
            long b = 1496665131;
            ModularArithmatic mod = new ModularArithmatic(5986660523);
            long m = 5986660523;
            Assert.AreEqual(54473761, mod.FastExponentiate(a, b));
        }
        [TestMethod]
        public void TestMethod7()
        {
            long a = 8059008699;
            long b = 5545299377;
            long m = 10993522499;
            Assert.AreEqual(25917, CryptoMethods.ModularArithmatic.FastExponentiate(a, b, m));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(25917, CryptoMethods.ModularArithmatic.EuclidianAlgorithm(25917, 25917 * 25917));
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual(1, CryptoMethods.ModularArithmatic.EuclidianAlgorithm(24157817, 39088169));
        }
        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(2, CryptoMethods.ModularArithmatic.EuclidianAlgorithm(512927377 * 2, 39088169 * 2));
        }
        [TestMethod]
        public void TestMethod11()
        {
            long inverse;
            Assert.IsFalse(!CryptoMethods.ModularArithmatic.FindInverse(113, 10993312800, out inverse));
            Assert.AreEqual(5545299377, inverse);
        }
        [TestMethod]
        public void TestMethod12()
        {
            long inverse;
            Assert.IsFalse(!CryptoMethods.ModularArithmatic.FindInverse(11, 1440, out inverse));
            Assert.AreEqual(131, inverse);
        }
        [TestMethod]
        public void TestMethod13()
        {
            long inverse;
            Assert.IsFalse(CryptoMethods.ModularArithmatic.FindInverse(36, 1440, out inverse));
            Assert.AreEqual(40, inverse);
        }
        [TestMethod]
        public void ComplexTest1()
        {
            Complex c = new Complex(1, 2, -1, new ModularArithmatic(5251));
            Assert.IsTrue(c.Real == 1 && c.Imaginary == 2 & c.AbstractRoot == -1);
            c.square();
            Assert.AreEqual(-3, c.Real);
            Assert.AreEqual(4, c.Imaginary);
        }
    }
}