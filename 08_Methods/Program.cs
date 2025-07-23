using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //void customerList()
            //{
            //    Console.WriteLine("Customer List");
            //    Console.WriteLine("1. John Doe");
            //    Console.WriteLine("2. Jane Smith");
            //    Console.WriteLine("3. Alice Johnson");
            //}
            //customerList();
            //void addCustomer(string name)
            //{
            //    Console.WriteLine($"Customer {name} has been added.");
            //}
            //addCustomer("Michael Brown");

            //void sumOperation(int a, int b)
            //{
            //    int result = a + b;
            //    Console.WriteLine($"The sum of {a} and {b} is {result}.");
            //}
            //sumOperation(5, 10);


            #endregion

            #region Methods That Return Value

            //string GetCustomerName(int id)
            //{
            //    // Simulating a customer database lookup
            //    if (id == 1) return "John Doe";
            //    if (id == 2) return "Jane Smith";
            //    if (id == 3) return "Alice Johnson";
            //    return "Unknown Customer";
            //}
            //string customerName = GetCustomerName(2);
            //Console.WriteLine($"Customer with ID 2: {customerName}");
            //Console.WriteLine(customerName);
            //int Multiply(int a, int b)
            //{
            //    return a * b;
            //}
            //int result = Multiply(4, 5);
            //Console.WriteLine($"The result of multiplication is: {result}");
            //Console.WriteLine(result);
            #endregion

            #region example application


            int examResults(string studentName, int exam1, int exam2, int exam3)
            {
                int   total = exam1 + exam2 + exam3;
                double average = total / 3.0;
                Console.WriteLine($"Student: {studentName}");
                Console.WriteLine($"Exam 1: {exam1}, Exam 2: {exam2}, Exam 3: {exam3}");
               
                return (int)average; // Return the average as an integer

            }
            int averageScore = examResults("Alice", 85, 90, 78);
            Console.WriteLine($"Average Score: {averageScore}");

            #endregion
        }
    }
}
