using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities
{
    public class FizzBuzzer
    {
        public static string GetValues(int input)
        {
            var output = string.Empty;
            if (input %3==0)
                output +="Fizz";
            if (input %5==0)
                output+= "Buzz";
            if (string.IsNullOrEmpty(output))
                return input.ToString();
            return output;
        }
    }
}
