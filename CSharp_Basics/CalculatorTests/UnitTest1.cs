using System;
using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void AddingOperation()
        {
            MathData mathData = new MathData(5, 3, "+");
            var result = Calculations.DoMath(mathData);

            Assert.AreEqual(8, result);
        }
    }
}
