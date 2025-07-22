using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region basic For Example

            //int limit;
            //Console.WriteLine("Please ENter How Many Times You Want to Write 'Eyes Chico, They Never Lie..' :");
            //limit = int.Parse(Console.ReadLine());  
            //for (int i = 0; i < limit; i++)
            //{
            //    Console.WriteLine("Eyes Chico, They Never Lie..");
            //}
            //Console.Read();
            #endregion

            #region For loop with If Conditions
            //int length;
            //Console.Write("Write the length of loop: ");
            //length = int.Parse(Console.ReadLine()); 
            //for (int i = 0; i < length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("Even Number: " + i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Odd Number: " + i);
            //    }
            //}
            #endregion

            #region For Loop Example
            //int bacterium = 1;
            //Console.WriteLine("We have 2 bacterium that breeding every hour.");
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine("After " + i + " hours, we have " + bacterium + " bacterium.");
            //}
            //Console.Read();
            #endregion

            #region While Loop Examples
            //Console.Write(" Write 20 times 'Say Good Night to The Bad Guy..' : ");
            //int i = 0;
            //while (i <= 20)
            //{
            //    Console.WriteLine("Say Good Night to The Bad Guy..");
            //    i++;    
            //}

            //int i = 0;
            //int num = 1;
            //while (i < 10)
            //{
            //    Console.WriteLine("The number is: " + num);
            //    num += i;
            //    i++;
            //}   
            #endregion

            #region Example Exam Question
            // Sum of digits of a 3-digit number

            Console.WriteLine("Enter a 3-digit number to calculate the sum of its digits:");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int originalNumber = number;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            Console.WriteLine($"The sum of the digits of {originalNumber} is: {sum}");
            Console.WriteLine("-----------------------------------------------------------");
            #endregion

        }
    }
}
