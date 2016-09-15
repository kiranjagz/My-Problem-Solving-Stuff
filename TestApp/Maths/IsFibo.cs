using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Maths
{
    public class IsFibo
    {
        /// <summary>
        /// Code needs to be complete
        /// </summary>
        /// <param name="valueToCheck"></param>
        /// <param name="previousValue"></param>
        /// <param name="currentValue"></param>
        /// <returns></returns>
        public static bool isFibo(int valueToCheck, int previousValue, int currentValue)
        {
            return currentValue > valueToCheck ? false : valueToCheck == currentValue ? true : isFibo(valueToCheck, previousValue - currentValue, currentValue);
        }
    }
}
