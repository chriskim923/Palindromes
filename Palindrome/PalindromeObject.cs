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
        public string TestString { get; }
        public string ReversedString;
        public bool IsPalindrome;

        public PalindromeObject(string str)
        {
            this.TestString = str;
            this.ReversedString = ReverseString(TestString);
            this.IsPalindrome = IsStringPalindrome(TestString);
        }

        public static string ReverseString(string TestString)
        {
            char[] charArray = TestString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string FormatString(string unformattedString)
        {
            string filteredString = Regex.Replace(unformattedString, @"\s+|,|-|'|:|\.|\?|\!|\(|\)|", "");
            string formattedString = filteredString.ToLower();
            return formattedString;
        }

        public static bool IsStringPalindrome(string TestString)
        {
            string formattedString = FormatString(TestString);
            int stringLength = formattedString.Length;
            int iterations = (stringLength - stringLength % 2) / 2;
            for (int i = 0; i < iterations; i++)
            {
                if (formattedString[i] != formattedString[stringLength - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
