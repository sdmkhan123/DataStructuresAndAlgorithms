using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.AlgorithmProgram
{
    public class PrimeNumBetweenRange
    {
        private static bool isPalindrome(int num)
        {
            int rem = 0;
            int sum = 0;
            int tempNum = num;
            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                sum = sum * 10 + rem;
            }
            if(sum == tempNum)
            {
                return true;
            }
            return false;
        }
        public static void primeNums()
        {
            int flag;
            int num = 1000;
            int i = 2;
            if (i == 2)
            {
                Console.Write(i + " ");
            }
            for (i = 3; i <= num; i++)
            {
                flag = 1;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    bool panlindromeRes = isPalindrome(i);
                    if(panlindromeRes == true)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}