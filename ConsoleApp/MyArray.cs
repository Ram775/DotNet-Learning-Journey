using System;

namespace Program
{
    public class MyArray
    {
        public static void Print()
        {
            int[] num = {1, 2, 3, 4, 5, 6, 7, 7, 8, 9, 10 };

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}