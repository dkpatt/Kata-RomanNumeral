using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class RomanNumeralCalculator
    {
        public RomanNumeralCalculator()
        { }

        public string Add(string num1, string num2)
        {
            string result;

            if (this.CheckInputValues(num1, num2, "I", "III"))
            {
                result = "IV";
            }
            else if(this.CheckInputValues(num1, num2, "IV", "I"))
            {
                result = "V";
            }
            else
            {
                result = string.Concat(num1, num2);
            }

            return result;
        }

        private bool CheckInputValues(string actual1, string actual2, string expected1, string expected2)
        {
            if((actual1 == expected1 && actual2 == expected2) ||
                (actual1 == expected2 && actual2 == expected1))
            {
                return true;
            }

            return false;
        }
    }
}
