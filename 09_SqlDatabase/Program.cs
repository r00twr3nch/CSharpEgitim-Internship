using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SqlDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pizzeria of Luigi!");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1 - Categories");
            Console.WriteLine("2 - Products");
            Console.WriteLine("3 - Orders");
            Console.WriteLine("4 - Exit System");
            Console.WriteLine("Please Enter Your Table Number:");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Internshipdb;Integrated Security=True");    
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From CategoryTable", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();  
            adapter.Fill(dataTable);

            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
               foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString()); 
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}