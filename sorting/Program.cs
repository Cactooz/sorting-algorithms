using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = { 10, 100, 1000, 10000, 100000 };
            int arraySize = 3;

            int[] listA = Utility.randomNumbers(sizes[arraySize]);
            int[] listB = Utility.randomNumbers(sizes[arraySize]);
            int[] listC = Utility.randomNumbers(sizes[arraySize]);

            Console.WriteLine("BubbleSort started");
            DateTime startTimeA = DateTime.Now;
            BubbleSortArray.BubbleSort(listA);
            TimeSpan timeA = DateTime.Now - startTimeA;
            Console.WriteLine($"BubbleSort done - Time: {timeA.TotalSeconds}s");

            Console.Write("\n");
            Console.WriteLine("InsertionSort started");
            DateTime startTimeB = DateTime.Now;
            InsertionSortArray.InsertionSort(listB);
            TimeSpan timeB = DateTime.Now - startTimeB;
            Console.WriteLine($"InsertionSort done - Time: {timeB.TotalSeconds}s");

            Console.Write("\n");
            Console.WriteLine("MergeSort started");
            DateTime startTimeC = DateTime.Now;
            MergeSortArray.MergeSort(listC);
            TimeSpan timeC = DateTime.Now - startTimeC;
            Console.WriteLine($"MergeSort done - Time: {timeC.TotalSeconds}s");
        }
    }
}