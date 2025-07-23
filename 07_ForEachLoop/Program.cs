using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForEach Loop Example

            //string[] cities = {"Milano", "Rome", "Florence", "Pisa", "Sicily", "Napoli" };
            //Console.WriteLine("Cities in Italy:");
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Even Numbers:");
            //foreach(int num in numbers)
            //{
            //    if(num % 2 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int total = 0;
            //foreach (int num  in numbers)
            //{
            //    total += num;
            //}
            //Console.WriteLine("Total of numbers: " + total);

            //List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
            //Console.WriteLine("Fruits in the list:");
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //string word = "WubbaLubbaDubDub";

            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region Example Grade Application

            //Console.WriteLine("-------------------Grade List For Students-------------------");

            //Console.WriteLine("Please Enter the Number of Students:");
            //int numberOfStudents = int.Parse(Console.ReadLine());
            //string[] students = new string[numberOfStudents];
            //for (int i = 0; i < numberOfStudents; i++)
            //{
            //    Console.WriteLine($"Please Enter the Name of Student {i + 1}:");
            //    students[i] = Console.ReadLine();
            //}
            //Console.WriteLine("-------------------------------------------------------------");
            //int studentGrades = 3;
            //for (int i = 0; i < numberOfStudents; i++)
            //{
            //    Console.WriteLine($"Please Enter the Grades for {students[i]}:");
            //    int[] grades = new int[studentGrades];
            //    for (int j = 0; j < studentGrades; j++)
            //    {
            //        Console.WriteLine($"Grade {j + 1}:");
            //        grades[j] = int.Parse(Console.ReadLine());
            //    }
            //    // Calculate average
            //    double average = grades.Average();

            //    if (average > 60) // Assuming 60 is the passing grade
            //    {
            //        Console.WriteLine($"{students[i]} has an average grade of {average} and is above average. Passed the Class");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{students[i]} has an average grade of {average} and is below average. Failed the Class");
            //    }
            //}
            //Console.WriteLine("-------------------------------------------------------------");
            //Console.WriteLine("Thank you for using the Grade Application!"); 
            #endregion

        }
    }
}
