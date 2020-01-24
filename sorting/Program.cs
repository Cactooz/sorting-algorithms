using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = { 10, 100, 1000, 10000, 100000 };
            int arraySize = 3;

            Stopwatch timer = new Stopwatch();

            int[] bubble1 = Utility.randomNumbers(sizes[arraySize]);
            int[] insert1 = Utility.randomNumbers(sizes[arraySize]);
            int[] merge1 = Utility.randomNumbers(sizes[arraySize]);

            Console.WriteLine("BubbleSort started");
            timer.Start();
            BubbleSortArray.BubbleSort(bubble1);
            timer.Stop();
            Console.WriteLine($"BubbleSort done - Time: {timer.Elapsed.TotalSeconds}s");
            timer.Reset();

            Console.Write("\n");
            Console.WriteLine("InsertionSort started");
            timer.Start();
            InsertionSortArray.InsertionSort(insert1);
            timer.Stop();
            Console.WriteLine($"InsertionSort done - Time: {timer.Elapsed.TotalSeconds}s");
            timer.Reset();

            Console.Write("\n");
            Console.WriteLine("MergeSort started");
            timer.Start();
            MergeSortArray.MergeSort(merge1);
            timer.Stop();
            Console.WriteLine($"MergeSort done - Time: {timer.Elapsed.TotalSeconds}s");
            timer.Reset();
        }
    }
}