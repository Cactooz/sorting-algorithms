using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    class MergeSortArray
    {
        public static int[] MergeSort(int[] list)
        {
            int[] left;
            int[] right;
            int[] result = new int[list.Length];
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (list.Length <= 1)
                return list;
            // The exact midpoint of our array  
            int middle = list.Length / 2;
            //Will represent our 'left' array
            left = new int[middle];

            //if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (list.Length % 2 == 0)
                right = new int[middle];
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[middle + 1];
            //populate left array
            for (int i = 0; i < middle; i++)
                left[i] = list[i];
            //populate right array   
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to midpont
            for (int i = middle; i < list.Length; i++)
            {
                right[x] = list[i];
                x++;
            }
            //Recursively sort the left array
            left = MergeSort(left);
            //Recursively sort the right array
            right = MergeSort(right);
            //Merge our two sorted arrays
            result = Merge(left, right);
            return result;
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}