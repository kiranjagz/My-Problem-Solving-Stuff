using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Maths
{
    public class CombinationSum
    {

        //int[] set = { -1, -2, -3, -4, -5, 1, 2, 3, 4, 5 };

        //    foreach (string s in GetCombinations(set, 0, ""))
        //    {
        //        Console.WriteLine(s);
        //    }

    public static IEnumerable<string> GetCombinations(int[] set, int sum, string values)
        {
            for (int i = 0; i < set.Length; i++)
            {
                int left = sum - set[i];
                string vals = set[i] + "," + values;

                if (left == 0)
                    yield return vals;               
                else
                {
                    int[] possible = set.Take(i).Where(n => n <= sum).ToArray();
                    if (possible.Length > 0)
                    {
                        foreach (string s in GetCombinations(possible, left, vals))
                        {
                            yield return s;
                        }
                    }
                }
            }
        }
    }
}
