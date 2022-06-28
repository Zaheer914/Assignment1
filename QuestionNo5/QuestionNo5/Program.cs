using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 23, 34, 54, 34, 23, 55, 65, 1, 3, 5 };
            maxValueList(list);
            
            
        }

        static void maxValueList(int[] list)
        {
            int maxValue = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] > maxValue)
                {
                    maxValue = list[i];
                }
            }
            Console.WriteLine("Max Value in the list is " +maxValue);
        }
    }
}
