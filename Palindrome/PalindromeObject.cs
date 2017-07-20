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
            isPalindrome = true;
            string formattedTestString = FormatString(testString);
            CheckPalindrome(formattedTestString);
        }

        public void Reverse()
        {
            char[] charArray = testString.ToCharArray();
            Array.Reverse(charArray);
            reversedString = new string(charArray);
        }

        public string FormatString(string unformattedString)
        {
            string formattedString = Regex.Replace(unformattedString, @"\s+|,|-|'|:|\.|\?|\!|\(|\)|", "");
            return formattedString;
        }

        public void CheckPalindrome(string formattedString)
        {
            // isPalindrome = string.Equals(formattedTestText, formattedReverseText, StringComparison.CurrentCultureIgnoreCase);
            // Alternative function
            int stringLength = formattedString.Length;
            int iterations = (stringLength - stringLength % 2) / 2;
            for (int i = 0; i < iterations; i++)
            {
                if (formattedString[i] != formattedString[stringLength - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }
        }
    }
}
