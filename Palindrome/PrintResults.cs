using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeProject
{
    class Display
    {
        private static string sectionBorderDashes = new string('-', 25);

        public static void PrintResults(PalindromeData testObject)
        {
            Console.WriteLine($"{sectionBorderDashes}" +
            $"\nIsPalindrome: {testObject.IsPalindrome}" +
            $"\n\tOriginal: {testObject.TestString}" +
            $"\n\tReversed: {testObject.ReversedString}" +
            $"\n{sectionBorderDashes}");
        }
        public static void PrintCache(List<PalindromeData> entryList)
        {
            List<PalindromeData> sortedList = entryList.OrderByDescending(obj => obj.IsPalindrome).ToList();
            Console.WriteLine(sectionBorderDashes);
            Console.WriteLine("IsPalindrome: Original String | Reversed String");
            foreach (PalindromeData entry in sortedList)
            {
                Console.WriteLine($"{entry.IsPalindrome}: {entry.TestString} -> {entry.ReversedString}");
            }
            Console.WriteLine(sectionBorderDashes);
        }
    }
}
