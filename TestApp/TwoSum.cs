using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class TwoSum
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            //var hs = new HashSet<int>();
            //list.ToList().ForEach(x => hs.Add(x));

            //for (int i = 0; i < hs.Count; i++)
            //{
            //    int value = list[i];
            //    var diff = sum - value;
            //    if (hs.Contains(diff))
            //    {
            //        var index = list.IndexOf(diff);
            //        return new Tuple<int, int>(i, index);
            //    }
            //}

            //return null;

            foreach (var item in list)
            {
                int diff = sum - item;
                if (list.Contains(diff))
                {
                    int index1 = list.IndexOf(item);
                    int index2 = list.IndexOf(diff);
                    return new Tuple<int, int>(index1, index2);
                }
            }

            return null;
        }
    }
}
