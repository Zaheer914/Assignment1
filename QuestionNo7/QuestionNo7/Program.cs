using System;

namespace QuestionNo7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 28, 37, 32, 23, 21, 45 };
            for (int i = 0; i < list.Length;)
            {
                Console.WriteLine(list[i]);
                i = i + 2;
            }
        }

    }
}