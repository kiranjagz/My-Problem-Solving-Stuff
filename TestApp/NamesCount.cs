using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    using System;
    using System.Collections.Generic;

    public class NamesCount
    {
        private int Count;
        private int nameCount;
        private Dictionary<int, string> Counts = new Dictionary<int, string>();

        public void AddName(string name)
        {
            //Counts.TryGetValue(name, out nameCount);
            Counts.Add(nameCount,name);

            //if (nameCount == 0)
            //    Counts[name] = nameCount;

            nameCount++;
            Count++;
        }

        public double NameProportion(string name)
        {
            double fraction = 0;
            double Occurances = 0;

            foreach (var item in Counts)
            {
                if (item.Value == name)
                {
                    Occurances++;
                }
            }

            fraction = Occurances / Count;

            return fraction;
        }
    }
}
