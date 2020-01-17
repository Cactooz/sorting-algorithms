using System;

namespace sorting
{
    class InsertionSortArray
    {
        public static void InsertionSort(int[] list)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("InsertionSort startad");
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (list[j - 1] > list[j])
                    {
                        Utility.Swap(ref list[j - 1], ref list[j]);
                    }
                }
            }
            TimeSpan time = DateTime.Now - startTime;
            Console.WriteLine($"InsertionSort klar - Tid: {time.TotalSeconds}s");
        }
    }
}
