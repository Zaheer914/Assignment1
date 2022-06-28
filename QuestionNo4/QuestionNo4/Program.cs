using System;

namespace QuestionNo4
{
        class Program
        {
            static void Main(string[] args)
            {
                
                Console.Write("Enter a Numeber : ");
                int number = Convert.ToInt32(Console.ReadLine());
                ElementPresence(number);

            
                
            }
            static void ElementPresence(int number)
            {
                int[] list = { 2, 3, 4, 6, 28, 37, 32, 23, 21, 45 };
                for (int i = 0; i < list.Length; i++)
                {
                
                    if (list[i] == number)
                    {
                        Console.WriteLine("Element Occurs in a list");
                        return;
                    }

                }
                Console.WriteLine("Element Not Occurs in a list");
            }

        }


 }