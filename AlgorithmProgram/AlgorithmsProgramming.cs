using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.AlgorithmProgram
{
    public class AlgorithmsProgramming
    {
        /// <summary>
        /// All algorithms problem solved here
        /// </summary>
        public void algoProgram()
        {
            AlgoProbFunctioons algoProbFunctions = new AlgoProbFunctioons();
            Console.WriteLine("***************************************************************************\n");
            Console.WriteLine("---------------Permutation--------------");
            Console.WriteLine("Enter a string to find the permutation");
            string str =  Console.ReadLine();
            //Constructor is called to create an object
            Console.Write("\nAll possible permutation strings are : ");
            algoProbFunctions.permutationOfString(str, "");
            Console.WriteLine("\n***************************************************************************\n");
            Console.WriteLine("--------------BinarySearch--------------");
            Console.WriteLine("Enter array of string");
            //string[] arr = Console.ReadLine().Split(", ");
            string[] arr = { "John", "Doe", "Doe", "John", "Another", "Name", "NameAnother" };
            Console.WriteLine("Enter a word that need to be find");
            //string word = Console.ReadLine();
            string word = "John";
            Array.Sort(arr);
            bool result = algoProbFunctions.binarySearch(arr, word);
            if (result == true)
                Console.WriteLine("Element present");
            else
                Console.WriteLine("Element not present");
            Console.WriteLine("\n***************************************************************************\n");
            Console.WriteLine("--------------BinarySearch--------------");
            Console.WriteLine("Enter array of string to be sorted");
            //string[] insertionArr = Console.ReadLine().Split(", ");
            string[] insertionArr = { "John Doe", "Doe John", "Another Name", "Name Another" };
            algoProbFunctions.insertionSort(insertionArr);
            foreach (string i in insertionArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\n***************************************************************************\n");
            Console.WriteLine("--------------BubbleSort--------------");
            BubbleSortAlgo bubbleSortAlgo = new BubbleSortAlgo();
            int[] intArr = { 64, 34, 25, 12, 22, 11, 90 };
            int n = intArr.Length;
            bubbleSortAlgo.bubbleSort(intArr, n);
            Console.WriteLine("Sorted array");
            bubbleSortAlgo.printArray(intArr, n);
            Console.WriteLine("\n***************************************************************************\n");
            Console.WriteLine("--------------MergeSort--------------");
            MergeSortAlgo mergeSortAlgo = new MergeSortAlgo();
            string[] mergeSortArray = { "foo", "bar", "alice", "bob", "celine", "david" };
            mergeSortAlgo.mergeSort(mergeSortArray, 0, mergeSortArray.Length - 1);
            Console.WriteLine("Sorted array");
            foreach (string i in mergeSortArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\n***************************************************************************\n");
            Console.WriteLine("--------------StringAnagrams--------------");
            Console.WriteLine("Enter the first string");
            char [] anagramStr1 = Console.ReadLine().ToCharArray();
            Console.WriteLine("Enter the second string");
            char[] anagramStr2 = Console.ReadLine().ToCharArray();
            AnagramsString anagramsString = new AnagramsString();
            string resultOfAnagram = anagramsString.toCheckAnagrams(anagramStr1, anagramStr2);
            Console.WriteLine("Given two strings are " + resultOfAnagram);
            Console.WriteLine("\n***************************************************************************\n");
            Console.WriteLine("--------------PrimeNumberBetweenRange--------------");
            PrimeNumBetweenRange.primeNums();
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}