using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeProject
{
    public class PalindromeData : Palindrome
    {
        public string TestString { get; }
        public string ReversedString { get; }
        public bool IsPalindrome { get; }

        public PalindromeData(string str)
        {
            this.TestString = str;
            this.ReversedString = base.ReverseString(TestString);
            this.IsPalindrome = base.IsStringPalindrome(TestString);
        }
    }
}
