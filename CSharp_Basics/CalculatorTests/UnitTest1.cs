using System;
using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1,4,5)]
        [TestCase(-1, 0, -1)]
        [TestCase(10, 1000, 1010)]
        [TestCase(-1, -2, -3)]
        public void AddingOperation_Positive_Values(int firstValue, int secondValue, int expectedResult)
        {
            // Arrange
            MathData mathData = new MathData(firstValue, secondValue, "+");

            // Act
            var result = Calculations.DoMath(mathData);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AddingOperation_Positive_Negative_Values()
        {
            // Arrange
            MathData mathData = new MathData(1, -1, "+");

            // Act
            var result = Calculations.DoMath(mathData);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void AddingOperation_Max_Values()
        {
            // Arrange
            MathData mathData = new MathData(int.MaxValue, int.MaxValue, "+");

            // Act
            var result = Calculations.DoMath(mathData);

            // Assert
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void AddingOperation_Big_Values()
        {
            // Arrange
            MathData mathData = new MathData(30000, 31000, "+");

            // Act
            var result = Calculations.DoMath(mathData);

            // Assert
            Assert.AreEqual(61000, result);
        }
    }
}
