using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            SumofNumbers(num1,num2);
        }

        static void SumofNumbers(int num1, int num2)
        {
            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is " + (num1+num2));
        }
    }
}