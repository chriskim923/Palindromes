using System;
using System.Collections.Generic;

namespace PalindromeProject
{
    public class Program
    {
        static void Main()
        {
            List<PalindromeData> entryList = new List<PalindromeData>();
            PalindromeData currentEntry;
            while (true)
            {
                Console.Write("Please select an option: " +
                    "\n\t1 - Enter string" + 
                    "\n\t2 - View Cached Results" +
                    "\nOption: ");
                var option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        Console.Write("Enter string: ");
                        string testString = Console.ReadLine();
                        currentEntry = new PalindromeData(testString);
                        entryList.Add(currentEntry);
                        Display.PrintResults(currentEntry);
                        break;
                    case "2":
                        Display.PrintCache(entryList);
                        break;
                    default:
                        Console.WriteLine($"'{option}' is not a valid option");
                        break;
                }
            }
        }
    }
}