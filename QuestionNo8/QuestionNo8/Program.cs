using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            PrimeNumber(number);
        }
        static void PrimeNumber(int number)
        {
            if (number == 0 || number == 1)
            {
                Console.WriteLine(number + " is Not a Prime Number");
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(number + " is Not a Prime Number");
                        return;
                    }
                }
                Console.WriteLine(number + " is a Prime Number");
            }
        }
    }
}