using System;

namespace sorting
{
    class Utility
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static int[] RandomNumbers(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(numbers.Length);
            return numbers;
        }
    }
}
