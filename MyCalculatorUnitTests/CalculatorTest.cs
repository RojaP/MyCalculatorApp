using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;

namespace MyCalculatorUnitTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();
            calculator.Operand1 = 10;
            calculator.Operand2 = 20;
            Assert.AreEqual(calculator.Add(), 40);
        }
        [TestMethod]
        public void TestSubtract()
        {
            Calculator calculator = new Calculator();
            calculator.Operand1 = 10;
            calculator.Operand2 = 20;
            Assert.AreEqual(calculator.Subtract(), -10);
        }
        [TestMethod]
        public void TestMultiply()
        {
            Calculator calculator = new Calculator();
            calculator.Operand1 = 10;
            calculator.Operand2 = 20;
            Assert.AreEqual(calculator.Multiply(), 200);
        }
        [TestMethod]
        public void TestDevide()
        {
            Calculator calculator = new Calculator();
            calculator.Operand1 = 10;
            calculator.Operand2 = 20;
            Assert.AreEqual(calculator.Divide(), 0);
        }
    }
}
