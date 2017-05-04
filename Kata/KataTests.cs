using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass]
    public class KataTests
    {
        RomanNumeralCalculator calculator; 

        [TestInitialize]
        public void SetupTests()
        {
            this.calculator = new RomanNumeralCalculator();
        }

        private void ExecuteAddTests(string firstNumber, string secondNumber, string expectedResult)
        {
            var result1 = this.calculator.Add(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, result1);

            var result2 = this.calculator.Add(secondNumber, firstNumber);
            Assert.AreEqual(expectedResult, result2);
        }

        [TestMethod]
        [DataRow("I", "I", "II", DisplayName = "Given_I_and_I_Equals_II")]
        [DataRow("I", "II", "III", DisplayName = "Given_I_and_II_Equals_III")]
        [DataRow("I", "III", "IV", DisplayName = "Given_I_and_III_Equals_IV")]
        [DataRow("IV", "I", "V", DisplayName = "Given_IV_and_I_Equals_V")]
        [DataRow("V", "II", "VII", DisplayName ="Given_V_and_II_Equals_VII")]
        public void Given_X_and_Y_Equals_Z(string firstNumber, string secondNumber, string expectedResult)
        {
            this.ExecuteAddTests(firstNumber, secondNumber, expectedResult);
        }

    }
}
