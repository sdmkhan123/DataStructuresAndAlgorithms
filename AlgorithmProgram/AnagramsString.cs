using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.AlgorithmProgram
{
    public class AnagramsString
    {
        /// <summary>
        /// Function to return if two strings are anagram or not anagram
        /// </summary>
        public string toCheckAnagrams(char [] str1, char [] str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            int[] countCharArray = new int[256];
            if(len1 != len2)
            {
                return "not anagram";
            }
            for (int i = 0; i < len1 && i<len2; i++)
            {
                countCharArray[str1[i] - 'a']++;
                countCharArray[str2[i] - 'a']--;
            }
            for (int i = 0; i < 256; i++)
            {
                if (countCharArray[i] != 0)
                {
                    return "not anagrams";
                }
            }
            return "anagrams";
        }
    }
}