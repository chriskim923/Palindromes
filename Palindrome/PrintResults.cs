using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class PrintResults
    {
        public static void DisplayResults(PalindromeData testObject)
        {
            Console.WriteLine($"Original: {testObject.TestString}");
            Console.WriteLine($"Reversed: {testObject.ReversedString}");
            Console.WriteLine($"Confirmed Palindrome: {testObject.IsPalindrome}");
        }
    }
}
