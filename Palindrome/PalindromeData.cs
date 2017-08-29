namespace PalindromeProject
{
    public class PalindromeData : Palindrome
    {
        public string TestString { get; }
        public string ReversedString { get; }
        public bool IsPalindrome { get; }

        public PalindromeData(string testString)
        {
            this.TestString = testString;
            this.ReversedString = base.ReverseString(testString);
            this.IsPalindrome = base.IsStringPalindrome(testString);
        }
    }
}
