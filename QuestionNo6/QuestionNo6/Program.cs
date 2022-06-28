using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number :");
            int number = Convert.ToInt32(Console.ReadLine());
            PrintTable(number);
        }

        static void PrintTable(int number)
        {   for (int i = 1; i <= 10; i++)
            {   
                Console.WriteLine(number + "x" + i + "=" + number*i);
            }
        }
    }
}