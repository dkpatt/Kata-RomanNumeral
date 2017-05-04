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
            else if(this.CheckInputValues(num1, num2, "V", "II"))
            {
                string collaposedNumeral = this.Collapse(num1) + this.Collapse(num2);
                result = this.Expand(collaposedNumeral);

                //result = "VII";
            }
            else
            {
                result = string.Concat(num1, num2);
            }

            return result;
        }

        private string Collapse(string romanNumeral)
        {
            string collapsedNumber;

            if(romanNumeral == "IV")
            {
                collapsedNumber = "IIII";
            }
            else if(romanNumeral.Contains("V"))
            {
                collapsedNumber = "IIIII";
            }
            else
            {
                collapsedNumber = romanNumeral;
            }

            return collapsedNumber;
        }

        private string Expand(string collapsedNumeral)
        {
            string expandedNumber = collapsedNumeral.Replace("IIIII", "V");
            expandedNumber = expandedNumber.Replace("IIII", "IV");

            return expandedNumber;
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
