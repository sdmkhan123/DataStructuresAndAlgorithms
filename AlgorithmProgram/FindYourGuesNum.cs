using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.AlgorithmProgram
{
    public class FindYourGuesNum
    {
        public static void guessNumber(int N, int m)
        {
            int mid = (N + m) / 2;
            Console.WriteLine("mid is " + mid);
            Console.WriteLine("\n-----------------------------------------------------------------------\n");
            Console.WriteLine("Press 1 if your number is equal to mid" +
                "\nPress 2 if your number less than mid\nPress 3 if your nummber is Greater than mid");
            Console.WriteLine("\n-----------------------------------------------------------------------\n");
            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                Console.WriteLine("Your Guess number is : " + mid);
                return;
            }
            else if(option == 2)
            {
                N = mid - 1;
                guessNumber(N, m);
            }
            else
            {
                m = mid + 1;
                guessNumber(N, m);
            }
        }
    }
}
