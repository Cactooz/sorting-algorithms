using System;
using System.Diagnostics;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
		int[] sizes = { 10, 100, 1000, 10000, 50000, 100000 }; //Array with sizes for the arrays

            	Stopwatch timer = new Stopwatch(); //Stopwatch for taking time

		//Go through all the values in the sizes array and execute the sortings
		for(int i = 0; i < sizes.Length; i++) {
			Console.WriteLine("——————————————————————");
			Console.WriteLine($"Sorting {sizes[i]} numbers"); //Write how many numbers are being sorted 
			Console.WriteLine("——————————————————————");

			//Make 4 arrays with random numbers, one for each sorting type
			int[] bubble = Utility.RandomNumbers(sizes[i]);
			int[] insert = Utility.RandomNumbers(sizes[i]);
			int[] insert2 = Utility.RandomNumbers(sizes[i]);
			int[] merge = Utility.RandomNumbers(sizes[i]);
			int[] quick = Utility.RandomNumbers(sizes[i]);

			Console.WriteLine($"BubbleSort{sizes[i]} started");
			timer.Start(); //Start the timer for BubbleSort
			BubbleSortArray.BubbleSort(bubble); //Sort the bubble array using the BubbleSortArray class
			timer.Stop(); //Stop the timer
			Console.WriteLine($"BubbleSort done - Time: {timer.Elapsed.TotalMilliseconds}ms"); //Write out the time
			timer.Reset(); //Reset the timer

			//Write out all sorted numbers in bubble
			/*for(int n = 0;n < bubble.Length;n++) {
				Console.WriteLine(bubble[n]);
			}*/

			Console.Write("\n"); //Empty line
			Console.WriteLine($"InsertionSort{sizes[i]} started");
			timer.Start(); //Start the timer for InsertionSort
			InsertionSortArray.InsertionSort(insert); //Sort the insert array uing the InsertionSortArray class
			timer.Stop(); //Stop the timer
			Console.WriteLine($"InsertionSort done - Time: {timer.Elapsed.TotalMilliseconds}ms"); //Write out the time
			timer.Reset(); //Reset the timer

			//Write out all sorted numbers in insert
			/*for(int n = 0;n < insert.Length;n++) {
				Console.WriteLine(insert[n]);
			}*/

			Console.Write("\n"); //Empty line
			Console.WriteLine($"InsertionSort(2){sizes[i]} started");
			timer.Start(); //Start the timer for InsertionSort
			InsertionSortArray2.InsertionSort(insert2); //Sort the insert array uing the InsertionSortArray class
			timer.Stop(); //Stop the timer
			Console.WriteLine($"InsertionSort(2) done - Time: {timer.Elapsed.TotalMilliseconds}ms"); //Write out the time
			timer.Reset(); //Reset the timer

			//Write out all sorted numbers in insert
			/*for(int n = 0;n < insert2.Length;n++) {
				Console.WriteLine(insert2[n]);
			}*/

			Console.Write("\n"); //Empty line
			Console.WriteLine($"MergeSort{sizes[i]} started");
			timer.Start(); //Start the timer for MergeSort
			MergeSortArray.MergeSortStart(merge); //Sort the merge array using the MergeSortArray class
			timer.Stop(); //Stop the timer
			Console.WriteLine($"MergeSort done - Time: {timer.Elapsed.TotalMilliseconds}ms"); //Write out the time
			timer.Reset(); //Reset the timer

			//Write out all sorted numbers in merge
			/*for(int n = 0;n < merge.Length;n++) {
				Console.WriteLine(merge[n]);
			}*/

			Console.Write("\n"); //EmptyLine
			Console.WriteLine($"QuickSort{sizes[i]} started");
			timer.Start(); //Start the timer for QuickSort
			QuickSortArray.QuickSortStart(quick); //Sort the quick array using the QuickSortArray class
			timer.Stop(); //Stop the timer
			Console.WriteLine($"QuickSort done - Time: {timer.Elapsed.TotalMilliseconds}ms"); //Write out the timer
			timer.Reset(); //Reset the timer

			//Write out all sorted numbers in quick
			/*for(int n = 0;n < quick.Length;n++) {
				Console.WriteLine(quick[n]);
			}*/

			Console.ReadLine(); //Stops the program until you press enter
		}
        }
    }
}
