using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = { 10, 1000, 1000000 };
            int[] list = randomNumbers(sizes[1]);
            BubbleSort(list);
        }
        static void BubbleSort(int[] list)
        {
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = 0; j < list.Length - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        Swap(ref list[j], ref list[j + 1]);
                    }
                }
            }
            TimeSpan time = DateTime.Now - startTime;

            for (int n = 0; n < list.Length; n++)
            {
                Console.WriteLine(list[n]);
            }
            Console.WriteLine($"{time.TotalMilliseconds}ms");
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int[] randomNumbers(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(numbers.Length);
            return numbers;
        }
    }
}