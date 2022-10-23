using NUnit.Framework;

namespace PracticeModule16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustBeCorrect()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Additional(100, 25) == 125);
        }

        [Test]
        public void SubtractionMustBeCorrect()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Subtraction(100, 25) == 75);
        }

        [Test]
        public void MiltiplicationMustBeCorrect()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Miltiplication(100, 25) == 2500);
        }

        [Test]
        public void DivisionMustBeCorrect()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Division(100, 25) == 4);
        }
    }
}
