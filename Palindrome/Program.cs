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
            List<object> cachedEntries = new List<object>();
            bool canContinue = true;
            while (canContinue)
            {
                Console.Write("Enter string: ");
                string testText = Console.ReadLine();
                string reverseText = Reverse(testText);
                bool isPalindrome = CheckPalindrome(testText, reverseText);
                DisplayResults(reverseText, isPalindrome);
                StoreResults(cachedEntries, testText, reverseText, isPalindrome);
                canContinue = CheckContinue();
            }
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static bool CheckPalindrome(string test, string reverse)
        {
            return test == reverse;
        }

        static void DisplayResults(string reverse, bool palindrome)
        {
            Console.WriteLine($"Reversed: {reverse}");
            Console.WriteLine($"Confirmed Palindrome: {palindrome}");
        }

        static void StoreResults(List<object> list, string test, string reverse, bool palindrome)
        {
            list.Add(new StoredEntry { UserText = test, ReversedText = reverse, IsPalindrome = palindrome });
            return;
        }

        static bool CheckContinue()
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
