using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.StringManipulation
{
    public class Anagrams
    {
        public static bool AreStringsAnagrams(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || (a.Length != b.Length))
                return false;

            foreach (char c in b)
            {
                int i = a.IndexOf(c);

                if (i >= 0)
                    a = a.Remove(i, 1);
                else return false;
            }

            return string.IsNullOrEmpty(a);
        }

    }
}
