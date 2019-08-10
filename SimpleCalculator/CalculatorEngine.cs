using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
     public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double results;

            switch (argOperation.ToLower())
            {
                case "add":
                case "plus":
                case  "+":
                    results = argFirstNumber + argSecondNumber;
                    break;
                case "subtract":
                case "minus":
                case  "-":
                    results = argFirstNumber - argSecondNumber;
                    break;
                case "multiply":
                case "times":
                case "*":
                    results = argFirstNumber * argSecondNumber;
                    break;
                case "divide":
                case "divided by":
                case "/":
                    results = argFirstNumber / argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified Operation not Recognized");
                }

            return results;
        }
    }
}
