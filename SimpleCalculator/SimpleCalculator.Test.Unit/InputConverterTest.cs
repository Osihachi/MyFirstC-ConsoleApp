using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter inputConverter =  new InputConverter();
        [TestMethod]
        public void ConvertValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "b";
            double convertedNumber = inputConverter.ConvertInputToNumeric(inputNumber);
            
        }
    }
}
