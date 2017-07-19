using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class PalindromeObject
    {
        public string testString;
        public string reversedString;
        public bool isPalindrome;

        public PalindromeObject(string str)
        {
            testString = str;
            Reverse();
            CheckPalindrome();
        }

        public void Reverse()
        {
            char[] charArray = testString.ToCharArray();
            Array.Reverse(charArray);
            reversedString = new string(charArray);
        }

        public void CheckPalindrome()
        {
            string formattedTestText = Regex.Replace(testString, @"\s+|,|-|'|:|\.|\?|\!|\(|\)|", "");
            string formattedReverseText = Regex.Replace(reversedString, @"\s+|,|-|'|:|\.|\?|\!|\(|\)|", "");
            isPalindrome = string.Equals(formattedTestText, formattedReverseText, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
