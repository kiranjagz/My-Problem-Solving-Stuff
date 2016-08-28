using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.StringManipulation
{
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            word = word.Trim().ToLower();

            var changetoArray = word.ToCharArray();
            Array.Reverse(changetoArray);

            string wordInBackwords = new string(changetoArray);
            wordInBackwords = wordInBackwords.Replace(" ", string.Empty);
            word = word.Replace(" ", string.Empty);

            if (word == wordInBackwords)
                return true;
            else
                return false;
        }
    }
}
