using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeProject.Tests
{
    [TestClass()]
    public class PalindromeObjectTests
    {
        [TestMethod()]
        public void ReverseStringTest()
        {
            PalindromeData TestPalindrome = new PalindromeData("Taco-cat?");
            var expectedString = "?tac-ocaT";
            var actualString = TestPalindrome.ReversedString;
            Assert.AreEqual<string>(expectedString, actualString);
        }

        [TestMethod()]
        public void FormatPalindromeStringTest()
        {
            Palindrome TestPalindrome = new Palindrome();
            var unformatted = "Test ,-':.?!() passed";
            var expectedString = "testpassed";
            var formattedString = TestPalindrome.FormatPalindromeString(unformatted);
            Assert.AreEqual<string>(formattedString, expectedString);
        }

        [TestMethod()]
        public void IsStringPalindromeTest()
        {
            var trueTest = new PalindromeData("Dammit! I'm mad");
            var falseTest = new PalindromeData("Fail Test");
            Assert.IsTrue(trueTest.IsPalindrome && !falseTest.IsPalindrome);
        }
    }
}