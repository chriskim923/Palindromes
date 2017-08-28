using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Test string
            //StringBuilder str = new StringBuilder();
            //str.Append('i', 1);
            //str.Append('x', 1000000);
            //string s = str.ToString();

            List<PalindromeData> EntryList = new List<PalindromeData>();
            PalindromeData currentTest;
            while (true)
            {
                Console.Write("Enter string: ");
                string testString = Console.ReadLine();
                //string testString = s;
                currentTest = new PalindromeData(testString);
                EntryList.Add(currentTest);
                PrintResults.DisplayResults(currentTest);
            }
        }

        
    }
}