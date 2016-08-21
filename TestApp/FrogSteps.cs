using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class FrogSteps
    {
        public static int RecursiveFrogSteps(int n)
        {
            if (n == 1)
                return 1;
            else if (n == 2)
                return 2;
            else
                return FrogSteps.RecursiveFrogSteps(n - 1) + FrogSteps.RecursiveFrogSteps(n - 2);
        }
    }
}
