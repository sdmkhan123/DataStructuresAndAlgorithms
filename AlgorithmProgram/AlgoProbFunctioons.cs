using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.AlgorithmProgram
{
    public class AlgoProbFunctioons
    {
        /// <summary>
        /// recurssive method to find all the distinct permutation string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="answer"></param>
        public void permutationOfString(string str, string answer)
        {
            if (str.Length == 0)
            {
                Console.Write(answer + "  ");
                return;
            }
            for (int i = 0; i < str.Length; i++)
            {
                //fix one char and find all possible combination for that
                char ch = str[i];
                string left_substr = str.Substring(0, i);
                string right_substr = str.Substring(i + 1);
                string rest = left_substr + right_substr;
                //calling recurssive function
                permutationOfString(rest, answer + ch);
            }
        }
        public bool binarySearch(string[] arr, string word)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int res = word.CompareTo(arr[mid]);
                // Check if word is present at mid
                if (res == 0)
                    return true;
                // If word greater, ignore left half
                if (res > 0)
                    left = mid + 1;
                // If word is smaller, ignore right half
                else
                    right = mid - 1;
            }
            return false;
        }

    }
}
