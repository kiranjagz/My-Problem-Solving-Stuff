using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sortList = new List<int>();

            Parallel.ForEach(File.ReadLines("c:\\test1.txt"), (line, _, lineNumber) =>
            {
                var sum = 0;
                var spilt = line.Split(',');
                var values = spilt.Select(int.Parse).ToArray();
                sum = values.Sum();
                Console.WriteLine($"Row:  {lineNumber.ToString()}: Sum : {sum.ToString()}");

                sortList.Add(sum);
            });

            WriteToFile(sortList.OrderBy(x => x).ToList());

            Console.Read();
        }

        static void WriteToFile(List<int> value)
        {
            using (StreamWriter writer = new StreamWriter("c:\\newtest1.txt", false))
            {
                value.ForEach(async x =>
                {
                    await writer.WriteLineAsync(x.ToString());
                });
            }
        }
    }
}
