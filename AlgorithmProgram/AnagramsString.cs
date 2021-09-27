﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.AlgorithmProgram
{
    public class AnagramsString
    {
        /// <summary>
        /// Function to return if two strings are anagram or not anagram
        /// </summary>
        public static string toCheckAnagrams(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            int[] countCharArray = new int[len1];
            if(len1 != len2)
            {
                return "not anagram";
            }
            for (int i = 0; i < str1.Length; i++)
            {
                countCharArray[str1[i] - 'a']++;
                countCharArray[str2[i] - 'a']--;
            }
            for (int i = 0; i < countCharArray.Length; i++)
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
