using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class CountCandies
    {
        public static int calculateEaten(int startingAmount, int newEvery)
        {
            int howManyEaten = 0;

            while (startingAmount > 1)
            {
                int remaining = startingAmount % newEvery;

                if (remaining != 0)
                {
                    howManyEaten = newEvery;
                    startingAmount = startingAmount - newEvery + 1;
                }
                else
                {
                    howManyEaten = howManyEaten + newEvery;
                    startingAmount = startingAmount - newEvery + 1;
                }
            }

            return howManyEaten + startingAmount;
        }
    }
}
