using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(5, calculator.Add(2, 3));
        }

        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual(1, calculator.Subtract(3, 2));
        }

        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(6, calculator.Multiply(2, 3));
        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(2, calculator.Divide(6, 3));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            calculator.Divide(1, 0);
        }
    }
}
    
