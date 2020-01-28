using System;

namespace sorting
{
    class InsertionSortArray
    {
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++) {
                for (int j = i + 1; j > 0; j--) {
                    if (array[j - 1] > array[j])
                        Utility.Swap(ref array[j - 1], ref array[j]);
                }
            }
            return array;
        }
    }
}
