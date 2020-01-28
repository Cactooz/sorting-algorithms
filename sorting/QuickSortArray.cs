using System;

namespace sorting
{
    class QuickSortArray
    {
        public static int[] QuickSortStart(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
            return array;
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];

            int lowIndex = low - 1;

            for(int j = low;j < high;j++) {
                if(array[j] <= pivot) {
                    lowIndex++;

                    Utility.Swap(ref array[lowIndex], ref array[j]);
                }
            }

            Utility.Swap(ref array[lowIndex + 1], ref array[high]);

            return lowIndex + 1;
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if(low < high) {
                int partIndex = Partition(array, low, high);

                QuickSort(array, low, partIndex - 1);
                QuickSort(array, partIndex + 1, high);
            }
        }
    }
}
