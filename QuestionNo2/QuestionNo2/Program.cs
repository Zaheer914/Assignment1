using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            EvenorOdd(number);
        }

        static void EvenorOdd(int number)
        {
            if (number%2 == 0)
            {
                Console.WriteLine(number + " is Even");
            }
            else
            {
                Console.WriteLine(number + " is Odd");
            }
        }
    }
}