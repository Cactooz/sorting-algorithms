using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = { 10, 10000, 100000 };
            int[] list = randomNumbers(sizes[1]);
            InsertionSort(list);
        }
        static void BubbleSort(int[] list)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("BubbleSort har startat");
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
            Console.WriteLine("BubbleSort är klar");
            /*for (int n = 0; n < list.Length; n++)
            {
                Console.WriteLine(list[n]);
            }*/
            Console.WriteLine($"Tid: {time.TotalSeconds}s");
        }

        static void InsertionSort(int[] list)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("InsertionSort har startat");
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (list[j - 1] > list[j])
                    {
                        Swap(ref list[j - 1], ref list[j]);
                    }
                }
            }
            TimeSpan time = DateTime.Now - startTime;
            Console.WriteLine("InsertionSort är klar");
            Console.WriteLine($"Tid: {time.TotalSeconds}s");
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
