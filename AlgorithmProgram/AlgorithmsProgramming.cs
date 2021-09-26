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
            Console.WriteLine("***************************************************************************\n");
            Console.WriteLine("Entter a string to find the permutation");
            string str =  Console.ReadLine();
            //Constructor is called to create an object
            PermutationOfString permutation = new PermutationOfString();
            Console.Write("\nAll possible permutation strings are : ");
            permutation.permute(str, "");
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}