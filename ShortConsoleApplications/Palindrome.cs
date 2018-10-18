using System;
namespace ShortConsoleApplications
{
    /* Write a function that checks if a given word is a palindrome. 
       Character case should be ignored.

    For example, IsPalindrome("Deleveled") should return true as character case 
    should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
    */
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            string lowerWord = word.ToLower();
            char[] charWord = lowerWord.ToCharArray();
            Array.Reverse(charWord);
            string reverseWord = new string(charWord);
            return lowerWord.Equals(reverseWord);
        }
    }
}
