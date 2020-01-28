using System;

namespace sorting
{
    class BubbleSortArray
    {
        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++) {
                for (int j = 0; j < array.Length - 1 - i; j++) {
                    if (array[j] > array[j + 1])
                        Utility.Swap(ref array[j], ref array[j + 1]);
                }
            }
            return array;
        }
    }
}
