using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Tests
{
    [TestClass()]
    public class PalindromeObjectTests
    {
        [TestMethod()]
        public void ReverseStringTest()
        {
            PalindromeObject Test = new PalindromeObject("Taco-cat?");
            string expectedString = "?tac-ocaT";
            string actualString = Test.ReversedString;
            Assert.AreEqual<string>(expectedString, actualString);
        }

        [TestMethod()]
        public void FormatStringTest()
        {
            var stringWithSpecialChars = "Test ,-':.?!()";
            var stringWithoutSpecialChars = "Test";
            var formattedString = PalindromeObject.FormatString(stringWithSpecialChars);
            Assert.AreEqual<string>(stringWithoutSpecialChars, formattedString);
        }
        [TestMethod()]

        public void IsStringPalindromeTest()
        {
            PalindromeObject trueTest = new PalindromeObject("Dammit! I'm mad");
            PalindromeObject falseTest = new PalindromeObject("Fail Test");
            Assert.IsTrue(trueTest.IsPalindrome && !falseTest.IsPalindrome);
        }
    }
}