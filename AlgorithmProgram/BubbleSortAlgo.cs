using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.AlgorithmProgram
{
    public class BubbleSortAlgo
    {
        /// <summary>
        /// bubble sort function to sort the array of int
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public void bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap both element at i aand j position
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                // IF no two elements were swapped by inner loop, then break to reduce the Time Complexity
                if (swapped == false)
                    break;
            }
        }
        /// <summary>
        /// Function to print an array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="size"></param>
        public void printArray(int[] arr, int size)
        {
            int i;
            for (i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
