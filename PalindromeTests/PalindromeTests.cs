using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeProject.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void ReverseStringTest1()
        {
            PalindromeData TestPalindrome = new PalindromeData("Taco-cat");
            var expectedString = "tac-ocaT";
            var actualString = TestPalindrome.ReversedString;
            Assert.AreEqual<string>(expectedString, actualString);
        }

        [TestMethod()]
        public void ReverseStringTest2()
        {
            PalindromeData TestPalindrome = new PalindromeData("Hello World");
            var expectedString = "dlroW olleH";
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
        public void IsStringPalindromeTest1()
        {
            var trueTest = new PalindromeData("Dammit! I'm mad");
            Assert.IsTrue(trueTest.IsPalindrome);
        }

        [TestMethod()]
        public void IsStringPalindromeTest2()
        {
            var falseTest = new PalindromeData("Fail Test");
            Assert.IsTrue(!falseTest.IsPalindrome);
        }
    }
}