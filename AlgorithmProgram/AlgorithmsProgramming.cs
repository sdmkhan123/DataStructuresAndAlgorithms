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
            AlgoProbFunctioons algoProbFunctioons = new AlgoProbFunctioons();
            Console.WriteLine("***************************************************************************\n");
            Console.WriteLine("---------------Permutation--------------");
            Console.WriteLine("Entter a string to find the permutation");
            string str =  Console.ReadLine();
            //Constructor is called to create an object
            Console.Write("\nAll possible permutation strings are : ");
            algoProbFunctioons.permutationOfString(str, "");
            Console.WriteLine("\n***************************************************************************\n");
            Console.WriteLine("--------------BinarySearch--------------");
            Console.WriteLine("Enter array of string");
            string[] arr = Console.ReadLine().Split(", ");
            Console.WriteLine("Enter a word that need to be find");
            string word = Console.ReadLine();
            Array.Sort(arr);
            bool result = algoProbFunctioons.binarySearch(arr, word);
            if (result == true)
                Console.WriteLine("Element present");
            else
                Console.WriteLine("Element not present");
            Console.WriteLine("\n***************************************************************************\n");
            Console.WriteLine("--------------BinarySearch--------------");
            Console.WriteLine("Enter array of string to be sorted");
            string[] insertionArr = Console.ReadLine().Split(", ");
            algoProbFunctioons.insertionSort(insertionArr);
            foreach (string i in insertionArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}