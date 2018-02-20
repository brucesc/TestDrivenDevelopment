using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicsLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //add
        //sub
        //multi
        //divide
        //square
        //inverse
        //negate
        //absolutevalue

        Class1 c1;

        [TestInitialize]
        public void TestInit()
        {
            c1 = new Class1();
        }

        //[Ignore]
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(4.5, c1.Add(1.5, 3.0));
            Assert.AreEqual(9, c1.Add(4.5, 4.5));
            Assert.AreEqual(-8, c1.Add(-12, 4));
        }

        //[Ignore]
        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual(9, c1.Subtract(76, 67));
            Assert.AreEqual(-5.4, c1.Subtract(-9, -3.6));
            Assert.AreEqual(0.2, c1.Subtract(10, 9.8), 0.1);
        }

        //[Ignore]
        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(15, c1.Multiply(5, 3));
            Assert.AreEqual(-7, c1.Multiply(-3.5, 2));
            Assert.AreEqual(57, c1.Multiply(-7.125, -8));
            Assert.AreEqual(19.9108, c1.Multiply(5.47, 3.64), 0.01);
        }

        //[Ignore]
        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(196, c1.Divide(98, 0.5));
            Assert.AreEqual(8, c1.Divide(65, 8.125));
            Assert.AreEqual(-12, c1.Divide(-144, 12));
            Assert.AreEqual(0.267974, c1.Divide(5.33, 19.89), 0.0001);
        }

        //[Ignore]
        [TestMethod]
        public void TestSquare()
        {
            Assert.AreEqual(144, c1.Square(12));
            Assert.AreEqual(9, c1.Square(3));
            Assert.AreEqual(64, c1.Square(8));
            Assert.AreEqual(56.8516, c1.Square(7.54), 0.1);
            Assert.AreEqual(6720.7204, c1.Square(- 81.98), 0.1);
        }

        //[Ignore]
        [TestMethod]
        public void TestInverse()
        {
            Assert.AreEqual(0.25, c1.Inverse(4));
            Assert.AreEqual(-0.125, c1.Inverse(-8));
            Assert.AreEqual(4, c1.Inverse(0.25));
        }

        //[Ignore]
        [TestMethod]
        public void TestNegate()
        {
            Assert.AreEqual(1, c1.Negate(-1));
            Assert.AreEqual(0.75, c1.Negate(-0.75), 0.1);
            Assert.AreEqual(-1, c1.Negate(1));
        }

        //[Ignore]
        [TestMethod]
        public void TestAbsolute()
        {
            Assert.AreEqual(1, c1.Absolute(-1));
            Assert.AreEqual(4, c1.Absolute(4));
            Assert.AreEqual(0.5, c1.Absolute(-0.5));

        }

        [Ignore]
        [TestMethod]
        public void TestSqRt()
        {

        }
    }
}
