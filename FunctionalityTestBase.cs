using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Test
{
    [TestClass]
    public class FunctionalityTests
    {
        [TestMethod]
        public void Test_Multiply_Result()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            Assert.AreEqual(calculator.Multiply(2, 4), 8);
        }

        [TestMethod]
        public void Test_Divide_Result()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            Assert.AreEqual(calculator.Divide(4, 2), 2);
        }

    }
}
