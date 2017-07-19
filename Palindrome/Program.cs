﻿using System;
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
            while (true)
            {
                Console.Write("Enter string: ");
                string testString = Console.ReadLine();
                currentTest = new PalindromeObject(testString);
                EntryList.Add(currentTest);
                DisplayResults(currentTest);
            }
        }

        static void DisplayResults(PalindromeObject testObject)
        {
            Console.WriteLine($"Original: {testObject.testString}");
            Console.WriteLine($"Reversed: {testObject.reversedString}");
            Console.WriteLine($"Confirmed Palindrome: {testObject.isPalindrome}");
        }
    }
}