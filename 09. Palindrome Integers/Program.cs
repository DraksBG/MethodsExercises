using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
           while (input != "END")
           {
               bool isIntegerPalindrome = IsNumberPalindrom(input);
               Console.WriteLine(isIntegerPalindrome.ToString().ToLower());
               input = Console.ReadLine();
           }
        }

        private static bool IsNumberPalindrom(string input)
        {
            int number = int.Parse(input);
            if (number >= 0 && number <= 9)
            {
                return true;
            }

            if (input[0] == input[input.Length - 1]) return true;

            return false;
        }
    }
}
