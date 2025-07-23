using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            //int[] numbers = new int[5]; 
            //numbers[0] = 10; 
            //numbers[1] = 20; 
            //numbers[2] = 30; 
            //numbers[3] = 40;
            //numbers[4] = 50; 
            //Console.WriteLine("Array Elements:");
            //Console.WriteLine(numbers[0]); 
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]); 
            //Console.WriteLine("Array Length: " + numbers.Length);

            //string[] cities = new string[5];
            //cities[0] = "Pisa";
            //cities[1] = "Rome";
            //cities[2] = "Milano";
            //cities[3] = "Zürih";
            //cities[4] = "Paris";

            //Console.WriteLine("Cities Array Elements:"); 
            //Console.WriteLine(cities[0]);
            //Console.WriteLine(cities[1]);
            //Console.WriteLine(cities[2]);
            //Console.WriteLine(cities[3]);
            //Console.WriteLine(cities[4]);
            //Console.WriteLine("Cities Array Length: " + cities.Length);
            #endregion

            #region List All Elements in Array

            //string[] cities = { "Zürih", "Luzern", "Pisa", "Rome", "Florence", "Milano"};
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine("City " + (i+1) + ": " + cities[i]);    
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, 34,21,57,48,3233,45,43 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //        Console.WriteLine("number is even");
            //    }
            //    else
            //     {
            //        Console.WriteLine(numbers[i]);
            //        Console.WriteLine("number is odd");
            //    }
            //}

            #endregion

            #region Find Max in Integer Array

            //int[] nums = {1,23,86,43,67,0,579,42,32,5667,98,24,34};
            //int maxValue = nums[0];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if(nums[i] > maxValue)
            //    {
            //        maxValue = nums[i];
            //    }
            //}
            //Console.WriteLine("The maximum value in the array is: " + maxValue);
            #endregion

            #region Sorting Array
            //int[] numbers = { 5, 2, 8, 1, 4 };
            //Console.WriteLine("Original Array:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}   
            //Array.Sort(numbers);
            //Console.WriteLine("\nSorted Array:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            #endregion

            #region Reverse Array
            //int[] numbers = { 5, 2, 8, 1, 4 };
            //Console.WriteLine("Original Array:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            //Array.Reverse(numbers);
            //Console.WriteLine("\nReversed Array:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            #endregion

            #region Array Methods

            //string[] fruits = { "Apple", "Banana", "Cherry", "Date" };
            //Array.IndexOf(fruits, "Cherry");
            //Console.WriteLine("Index of 'Cherry': " + Array.IndexOf(fruits, "Cherry"));

            //int[] numbers = { 1, 2, 3, 4, 5, 35, 67,89, 654, 31, 325, 56, 78, 765};
            //Console.WriteLine("The Maximumu value of Array is: " + numbers.Max());
            //Console.WriteLine("The Minimum value of Array is: " + numbers.Min());
            //Console.WriteLine("The Sum of Array is: " + numbers.Sum());
            //Console.WriteLine("The Average of Array is: " + numbers.Average()); 
            //Console.WriteLine("The Count of Array is: " + numbers.Count());
            //Console.WriteLine("The First Element of Array is: " + numbers.First());

            #endregion

            #region Get Input From User

            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Enter number " + (i + 1) + ": ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("You entered the following numbers:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Number " + (i + 1) + ": " + numbers[i]);
            //}
            #endregion


            Console.Read();
        }
    }
}
