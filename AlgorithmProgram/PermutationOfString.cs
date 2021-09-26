using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.AlgorithmProgram
{
    public class PermutationOfString
    {
        /// <summary>
        /// recurssive method to find all the distinct permutation string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="answer"></param>
        public void permute(string str, string answer)
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
                permute(rest, answer + ch);
            }
        }
    }
}
