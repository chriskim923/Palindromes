using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canContinue = true;
            while (canContinue)
            {
                Console.Write("Enter string: ");
                string testText = Console.ReadLine();
                string reverseText = Reverse(testText);
                bool isPalindrome = CheckPalindrome(testText, reverseText);
                DisplayResults(reverseText, isPalindrome);
                canContinue = CheckContinue();
            }
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool CheckPalindrome(string test, string reverse)
        {
            return test == reverse;
        }

        public static void DisplayResults(string reverse, bool palindrome)
        {
            Console.WriteLine($"Reversed: {reverse}");
            Console.WriteLine($"Confirmed Palindrome: {palindrome}");
        }

        public static bool CheckContinue()
        {
            Console.Write("Continue? (Y/N)");
            string response = Console.ReadLine();
            if (String.Equals(response, "y", StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            else if (String.Equals(response, "n", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
                return CheckContinue();
            }
        }
    }
}
