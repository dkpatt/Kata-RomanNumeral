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

        public string Add(string numeral1, string numeral2)
        {
            string collaposedNumeral = this.Collapse(numeral1) + this.Collapse(numeral2);
            string result = this.Expand(collaposedNumeral);

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
    }
}
