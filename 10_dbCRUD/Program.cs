using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_dbCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Add Category Example
            //Console.WriteLine("Welcome to the Pizzeria of Luigi!");
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Please write the category you want to add:");    
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Internshipdb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO CategoryTable (CategoryName) VALUES (@CategoryName)", connection);
            //command.Parameters.AddWithValue("@CategoryName", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Category added successfully!"); 
            #endregion

            #region Adding Product Example 
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.WriteLine("Please Write the Product You Want to Add: ");
            //productName = Console.ReadLine();
            //Console.WriteLine("Please Enter the Price Of Product: ");
            //productPrice = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Please Enter the Status of Product (True/False): ");
            //productStatus = Convert.ToBoolean(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Internshipdb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO ProductTable (ProductName, ProductPrice, ProductStatus) VALUES (@ProductName, @ProductPrice, @ProductStatus)", connection);
            //command.Parameters.AddWithValue("@ProductName", productName);
            //command.Parameters.AddWithValue("@ProductPrice", productPrice);
            //command.Parameters.AddWithValue("@ProductStatus", productStatus);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Product added successfully!");
            //Console.Read();

            #endregion

            #region List İtems Example
            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Internshipdb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("SELECT * FROM ProductTable", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //      foreach (var item in row.ItemArray)
            //      {
            //          Console.Write(item.ToString() + " ");
            //    }   
            //      Console.WriteLine();
            //}
            //connection.Close();

            //Console.Read();
            #endregion

            #region Delete Item Example

            //Console.Write("Please Enter the Item You Want to Delete: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Internshipdb;Integrated Security=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From ProductTable Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("The Item Deleted Successfully");

            //Console.Read();


            #endregion

            #region Update Item Example
            //Console.WriteLine("Id Of Item That Needs to Update: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter the New Name of Product: ");
            //string  productName = Console.ReadLine();
            //Console.WriteLine("Please Enter the New Price of Product: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter the New Status of Product (True/False): ");
            //bool productStatus = Convert.ToBoolean(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Internshipdb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("UPDATE ProductTable SET ProductName=@ProductName, ProductPrice=@ProductPrice, ProductStatus=@ProductStatus WHERE ProductId=@ProductID ", connection);
            //command.Parameters.AddWithValue("@ProductID", productId);
            //command.Parameters.AddWithValue("@ProductName", productName);
            //command.Parameters.AddWithValue("@ProductPrice", productPrice);
            //command.Parameters.AddWithValue("@ProductStatus", productStatus);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("The Item Updated Successfully");
            //Console.Read();
            #endregion
        }
    }
}
