using System;
using System.Linq;
using System.Collections.Generic;

namespace exercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter a word you want to check- ");
            string word = Console.ReadLine();
            System.Console.WriteLine("Is " + word + " a palindrome? - : " + isPalindrome(word));
        }

        static bool isPalindrome(String word)
        {
            if (word.Length == 0) return false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - 1 - i]) return false;

            }
            return true;
        }
    }
}