using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeProject
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
                Console.Write("Please select an option: \n\t1 - Enter string \n\t2 - View Cached Results \nOption: ");
                var option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        Console.Write("Enter string: ");
                        string testString = Console.ReadLine();
                        //string testString = s;
                        currentTest = new PalindromeData(testString);
                        EntryList.Add(currentTest);
                        Display.PrintResults(currentTest);
                        break;
                    case "2":
                        Display.PrintCache(EntryList);
                        break;
                    default:
                        Console.WriteLine($"'{option}' is not a valid option");
                        break;
                }
                
            }
        }

        
    }
}