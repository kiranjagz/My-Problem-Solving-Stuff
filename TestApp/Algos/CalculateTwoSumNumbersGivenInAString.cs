using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Algos
{
    public static class CalculateTwoSumNumbersGivenInAString
    {
        public static int SumTwoNumbersInAString(string number)
        {
            var n = number;

            var value = n.ToString();

            var splitToArray = value.ToCharArray();

            var numOne = int.Parse(splitToArray[0].ToString());
            var numTwo = int.Parse(splitToArray[1].ToString());

            var sum = numOne + numTwo;

            return sum;
        }
    }
}
