using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public static class LongestRunIndex
    {
        public static Int32 IndexOfLongestRun(this String value)
        {
            var currentRunLength = 0;
            var currentRunIndex = 0;

            var longestRunLength = 0;
            var longestRunIndex = 0;

            for (var i = 1; i < value.Length; i++)
            {
                var currentCharacter = value[i];
                var previousCharacter = value[i - 1];

                if (previousCharacter == currentCharacter)
                {
                    currentRunLength++;
                }
                else
                {
                    if (longestRunLength < currentRunLength)
                    {
                        longestRunLength = currentRunLength;
                        longestRunIndex = currentRunIndex;
                    }

                    currentRunLength = 0;
                    currentRunIndex = i;
                }
            }

            if (longestRunLength < currentRunLength)
            {
                longestRunLength = currentRunLength;
                longestRunIndex = currentRunIndex;
            }

            return longestRunIndex;
        }
    }

}
