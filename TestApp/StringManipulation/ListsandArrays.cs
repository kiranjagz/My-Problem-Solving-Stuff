using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.StringManipulation
{
    public class ListsandArrays
    {
        public Tuple<string,string> FindbyArrayId(int position, string value)
        {
            string[] name = new string[] { "kiran", "jeff", "bob" };

            int length = name.Length;

            for (int k = 0;k <= length;k++)
            {
                string item = name[k];

                if (item == value)
                    return new Tuple<string, string>(k.ToString(), name[k]);
            }

            return null;
        }

        public ArrayList InsertIntoSpecificPosition(int position, string value)
        {
            ArrayList names = new ArrayList() { "kiran", "may", "snow" };

            names.Insert(position, value);

            return names;
        }
    }
}
