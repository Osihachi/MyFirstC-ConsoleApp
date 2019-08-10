using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;

            // bool isconvertedsuccessfully = double.TryParse(input, out convertedNumber);
            //if(isconvertedsuccessfully)
            //or
            // if (!double.TryParse(argTextInput, out convertedNumber)) ;


            if (!double.TryParse(argTextInput, out convertedNumber))
                throw new ArgumentException("Expected a Numeric Value");

            

            return convertedNumber;
        }
}
}
