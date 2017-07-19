using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<PalindromeObject> EntryList = new List<PalindromeObject>();
            PalindromeObject currentTest;
            bool canContinue = true;
            while (canContinue)
            {
                Console.Write("Enter string: ");
                string testString = Console.ReadLine();
                currentTest = new PalindromeObject(testString);
                EntryList.Add(currentTest);
                DisplayResults(currentTest);
                canContinue = CheckContinue();
            }
        }

        static void DisplayResults(PalindromeObject testObject)
        {
            Console.WriteLine($"Original: {testObject.testString}");
            Console.WriteLine($"Reversed: {testObject.reversedString}");
            Console.WriteLine($"Confirmed Palindrome: {testObject.isPalindrome}");
        }

        public static bool CheckContinue()
        {
            var yesList = new List<string> { "y", "yes" };
            var noList = new List<string> { "n", "no" };
            while (true)
            {
                Console.Write("Continue? (Y/N)");
                string response = Console.ReadLine();
                if (yesList.Contains(response, StringComparer.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (noList.Contains(response, StringComparer.OrdinalIgnoreCase))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }
            }
        }
    }
}