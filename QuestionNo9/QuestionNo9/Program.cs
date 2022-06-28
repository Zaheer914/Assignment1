using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Multiple Print");
            Console.WriteLine();
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            Console.WriteLine();
            Console.WriteLine("Using Loops");
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}