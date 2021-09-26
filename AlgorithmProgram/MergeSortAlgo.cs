using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.AlgorithmProgram
{
    public class MergeSortAlgo
    {
        /// <summary>
        /// Merge sort fuction to Divide the array into two part
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void mergeSort(string[] arr, int left, int right)
        {
            if (left == right)
            {
                return;
            }
            //find mid position
            int mid = (left + right) / 2;
            // sort the first and the second half
            mergeSort(arr, left, mid);
            mergeSort(arr, mid + 1, right);
            merge(arr, left, mid, right);
        }
        /// <summary>
        /// merge functio to Conquer two sorted array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="mid"></param>
        /// <param name="to"></param>
        public void merge(string[] arr, int left, int mid, int right)
        {
            int n = right - left + 1;
            string[] tempArr = new string[n];
            int i1 = left;
            int i2 = mid + 1;
            int j = 0;
            //compare fuction and put smaller one from Left and right array into final sorted array
            while (i1 <= mid && i2 <= right)
            {
                if (arr[i1].CompareTo(arr[i2]) < 0)
                {
                    tempArr[j] = arr[i1];
                    i1++;
                }
                else
                {
                    tempArr[j] = arr[i2];
                    i2++;
                }
                j++;
            }
            //when 2nd array over
            while (i1 <= mid)
            {
                tempArr[j] = arr[i1];
                i1++;
                j++;
            }
            while (i2 <= right)
            {
                tempArr[j] = arr[i2];
                i2++;
                j++;
            }
            // copy back from the temporary array to original array
            for (j = 0; j < n; j++)
            {
                arr[left + j] = tempArr[j];
            }
        }
    }
}