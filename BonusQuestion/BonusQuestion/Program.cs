using System;

namespace BonusQuestion
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter a Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            palindrome(number);

            static void palindrome(int number)
            {
                int sum = 0;
                int newNumber = number;
                while (number > 0)
                {
                    int remainder = number % 10;
                    sum = (sum * 10) + remainder;
                    number = number / 10;

                }
                if (sum == newNumber)
                {
                    Console.WriteLine("It is a Palindrome Number");
                }
                else
                {
                    Console.WriteLine("It is Not a Palindrome Number");
                }
            } 
        }
    }
}