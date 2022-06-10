using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            SearchForVoweles(inputText);
        }

        private static void SearchForVoweles(string text)
        {
            int count = 0;
            // Console.WriteLine(text.Count(vowles => "aouei".Contains(vowles)));
            foreach (char vowle in text)
            {
                if ("aouei".Contains(vowle))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
