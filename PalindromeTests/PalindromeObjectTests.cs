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
        public void ReverseTest()
        {
            PalindromeObject Test = new PalindromeObject("Taco-cat?");
            string expectedString = "?tac-ocaT";
            string actualString = Test.reversedString;
            Assert.AreEqual<string>(expectedString, actualString);
        }

        [TestMethod()]
        public void CheckPalindromeTest()
        {
            PalindromeObject trueTest = new PalindromeObject("Dammit! I'm mad");
            PalindromeObject falseTest = new PalindromeObject("Fail Test");
            Assert.IsTrue(trueTest.isPalindrome && !falseTest.isPalindrome);
        }
    }
}