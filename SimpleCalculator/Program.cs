using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
              {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double FirstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double SecondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double results = calculatorEngine.Calculate(operation, FirstNumber, SecondNumber);


                Console.WriteLine(results);
               }
            catch (Exception ex)
                {
                //1000: start logging
                Console.WriteLine( ex.Message);
                }
           
        }
    }
}
