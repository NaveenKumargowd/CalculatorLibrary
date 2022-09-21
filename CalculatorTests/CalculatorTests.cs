using CalculatorLibrary;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class Tests
    {
        Calculator calc=new Calculator();

        [Test]
        public void ShouldAddTwoNumbers()
        {
            double x = 10.30;
            double y = 11.20;
            double sum= calc.Add(x,y);

            Assert.AreEqual(sum,21.50);
        }

        [Test]
        public void ShouldSubtractTwoNumbers()
        {
            double x = 21.20;
            double y = 10.50;
            double subtract = calc.Subtract(x, y);

            Assert.AreEqual(subtract, 10.70);

        }

        [Test]
        public void ShouldDivideTwoNumbers()
        {
            double x = 10.20;
            double y = 5.00;
            double divide = calc.Divide(x, y);

            Assert.AreEqual(divide, 2.04);

        }

        [Test]
        public void MultiplyTwoNumbers()
        {
            double x = 10.20;
            double y = 5.20;
            double multiply = calc.Multiply(x, y);

            Assert.AreEqual(multiply, 53.04);

        }
    }
}