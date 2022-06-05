using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Algos
{
    public static class MergedSortedArrays
    {
        public static void SortUsingLinq()
        {
            List<int> sort_num_Linq = new List<int>() { 5, 3, 1, 4, 9 };
            List<int> sort_num_Linq_2 = new List<int>() { 6, 2, 7, 8, 9 };

            var aft_sort = (from x in sort_num_Linq
                            orderby x
                            select x).ToList();

            var aft_sort_2 = (from x in sort_num_Linq_2
                              orderby x
                              select x).ToList();

            var jointLists = aft_sort.Concat(aft_sort_2)
                .OrderBy(x => x)
                .Select(x => x);

            foreach (var item in jointLists)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static void SortUsingForLoop()
        {
            List<int> UnsortedArrayOne = new List<int>() { 5, 3, 1, 4, 9 };
            List<int> UnsortedArrayTwo = new List<int>() { 6, 2, 7, 8, 9 };
        }
    }
}
