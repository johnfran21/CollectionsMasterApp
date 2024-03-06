﻿using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50

            int[] arrayOfFifty = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Console.WriteLine("Print 50 Random Numbers:");
            Populater(arrayOfFifty);
            NumberPrinter(arrayOfFifty);

            //TODO: Print the first number of the array

            Console.WriteLine("First number of the array:");
            Console.WriteLine(arrayOfFifty[0]);

            //TODO: Print the last number of the array

            Console.WriteLine("Last number of the array:");
            Console.WriteLine(arrayOfFifty[arrayOfFifty.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();

            NumberPrinter(arrayOfFifty);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(arrayOfFifty);
            NumberPrinter(arrayOfFifty);

            Console.WriteLine("---------REVERSE CUSTOM------------"); //skip
            ReverseArray(arrayOfFifty);


            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(arrayOfFifty);


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */

            Console.WriteLine("Sorted numbers:");
            Array.Sort(arrayOfFifty);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            List<int> list = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine("Capacity of List:");
            Console.WriteLine(list.Capacity);


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Console.WriteLine("All numbers in List:");
            Populater(list);
            NumberPrinter(list);
            Console.WriteLine();

            Console.WriteLine("Number of elements in List:");
            Console.WriteLine(list.Count);

            //TODO: Print the new capacity
            Console.WriteLine("New Capacity of List:");
            Console.WriteLine(list.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" by accident your app should handle that!
            //Console.WriteLine("What number will you search for in the number list?");


            bool canParse;
            int userInput;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                canParse = int.TryParse(Console.ReadLine(), out userInput);

            } while (canParse == false);

            NumberChecker(list, userInput);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(list);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            list.Sort();
            NumberPrinter(list);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            int[] newArray = list.ToArray();


            //TODO: Clear the list

            Console.WriteLine("I should see nothing below this:");
            list.Clear();
            NumberPrinter(list);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
                NumberPrinter(numbers);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count-1; i >=0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
                NumberPrinter(numberList);
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool foundNumber = false;
            foreach (int number in numberList)
            {
                if(number == searchNumber)
                {
                    Console.WriteLine($"{searchNumber} is in the List.");
                    break;
                }
                //else
                //{
                //    Console.WriteLine($"{searchNumber} is Not in the List.");
                //}
            }
            if (foundNumber == false)
            {
                Console.WriteLine($"{searchNumber} is Not in the List.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 51; i++)
            {
                int randomNumber = rng.Next(51);
                numberList.Add(randomNumber);
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i <= 49; i++)
            //for (int i = 0; i <= numbers.Length ; i++)

            {
                numbers[i] = rng.Next(0, 51);
            }
            
        }        

        private static void ReverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            //int[] newArray = new int[50];
            int index = 0;
            for (int i = array.Length-1; i >= 0; i--)
            {
                newArray[index] = array[i];
                index++;
            }
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
