using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = { 10, 100, 1000, 10000, 100000 };
            int[] list = Utility.randomNumbers(sizes[2]);
            InsertionSortArray.InsertionSort(list);
        }
    }
}