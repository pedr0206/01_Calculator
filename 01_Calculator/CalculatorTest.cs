using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[15];
          //  Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            numbers[2] = 10;
            Assert.AreEqual(28, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            numbers[2] = 10;
            numbers[3] = 7;
            numbers[4] = 11;
            numbers[5] = 10;
            numbers[6] = 7;
            numbers[7] = 11;
            numbers[8] = 10;
            numbers[9] = 7;
            numbers[10] = 11;
            numbers[11] = 10;
            numbers[12] = 7;
            numbers[13] = 11;
            numbers[14] = 10;
            Assert.AreEqual(140, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply()
        {
            //It multiplies two numbers
            //It multiplies several numbers
            Assert.AreEqual(0, Calculator.Multiply(0,0));
            Assert.AreEqual(0, Calculator.Multiply(2, 0));
        }
        [TestMethod]
        public void Power()
        {
            //It raises one number to the power of another number
            Assert.AreEqual(0, Calculator.Power(0, 2));
            Assert.AreEqual(16, Calculator.Power(4, 2));
        }
        [TestMethod]
        public void Factorial()
        {

            Assert.AreEqual(120, Calculator.Factorial(5));
            Assert.AreEqual(5040, Calculator.Factorial(7));
            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            //  it "computes the factorial of 1"
            //  it "computes the factorial of 2"
            //  it "computes the factorial of 5"
            //  it "computes the factorial of 10"
            
        }
    }
}
