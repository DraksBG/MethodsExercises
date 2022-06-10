using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());
           MatrixCreator(input);
        }

        private static void MatrixCreator(int input)
        {
            for (int rows = 0; rows < input; rows++)
            {
                for (int cols = 0; cols < input; cols++)
                {
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
