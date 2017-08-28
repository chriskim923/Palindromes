using System;
using System.Text.RegularExpressions;

namespace PalindromeProject
{
    public class Palindrome
    {
        public string ReverseString(string testString)
        {
            char[] reversedChars = new char[testString.Length];

            for (int i = 0, j = testString.Length - 1; i <= j; i++, j--)
            {
                reversedChars[i] = testString[j];
                reversedChars[j] = testString[i];
            }
            return new string(reversedChars);
        }

        public string FormatPalindromeString(string unformattedString)
        {
            var filteredString = Regex.Replace(unformattedString, @"[^a-zA-Z]+", "");
            string formattedString = filteredString.ToLower();
            return formattedString;
        }

        public bool IsStringPalindrome(string testString)
        {
            string formattedString = FormatPalindromeString(testString);
            
            for (int i = 0, j = formattedString.Length - 1; i <= j; i++, j--)
            {
                if (formattedString[i] != formattedString[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
