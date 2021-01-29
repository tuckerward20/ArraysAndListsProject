using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int number in myArray)
            {
                int evenOrOdd = number % 2;
                if (evenOrOdd == 0)
                {
                    evens.Add(number);
                }
                else if (evenOrOdd == 1)
                {
                    odds.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.Write($"Odds: ");
            for (int i = 0; i < odds.Count; i++)
            {
                Console.Write($"{odds[i]} ");
            }

            Console.Write($"\nEvens: ");
            for (int i = 0; i < evens.Count; i++)
            {
                Console.Write($"{evens[i]} ");
            }
            
        }
    }
}
