using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data.SqlClient;
using HawkerCorner_App.Models;

namespace HawkerCorner_App.DAL
{
    public class FoodOrderDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;

        //Constructor
        public FoodOrderDAL()
        {
            //Read ConnectionString from appsettings.json file
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string strConn = Configuration.GetConnectionString("HCConnectionString");
            //Instantiate a SqlConnection object with the
            //Connection String read.
            conn = new SqlConnection(strConn);
        }

        // Get all FoodOrders
        public List<FoodOrder> GetAllFoodOrders()
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM FoodOrder WHERE DelivererID IS NULL ORDER BY OrderID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end, save data into a food order list
            List<FoodOrder> foodOrderList = new List<FoodOrder>();

            while (reader.Read())
            {
                foodOrderList.Add(
                new FoodOrder
                {
                    OrderID = reader.GetString(0),
                    UserID = reader.GetString(1),
                    DelivererID = !reader.IsDBNull(2) ? reader.GetString(2) : null,
                    StoreID = reader.GetString(3),
                    Address = reader.GetString(4),
                    OrderList = reader.GetString(5),
                    Date = reader.GetDateTime(6),
                    OrderConfirm = reader.GetString(7),
                    OrderComplete = reader.GetString(8),
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();

            return foodOrderList;
        }

        // Get specified FoodOrder and Change Status
        public FoodOrder ChangeFoodOrderStatus(string orderID, string loginID)
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();

            //Specify an UPDATE SQL statement
            cmd.CommandText = @"UPDATE FoodOrder SET OrderConfirm = 'Confirmed', DelivererID = @DelivererID WHERE OrderID = @OrderID";
            //Define the parameters used in SQL statement, value for each parameter
            //is retrieved from respective class's property.
            cmd.Parameters.AddWithValue("@OrderID", orderID);

            cmd.Parameters.AddWithValue("@DelivererID", loginID);

            //Open a database connection
            conn.Open();
            //ExecuteNonQuery is used for UPDATE and DELETE
            cmd.ExecuteNonQuery();
            //Close the database connection
            conn.Close();

            return GetFoodOrderDetails(orderID, loginID);
        }

        // Get Specific Order Details
        public FoodOrder GetFoodOrderDetails(string orderID, string loginID)
        {
            FoodOrder foodOrder = new FoodOrder();

            // Retrieve the updated details of the specified order
            //Create a SqlCommand object from connection object
            SqlCommand cmd2 = conn.CreateCommand();

            cmd2.CommandText = @"SELECT * FROM FoodOrder WHERE OrderID = @OrderID";

            cmd2.Parameters.AddWithValue("@OrderID", orderID);

            //Open a database connection
            conn.Open();
            //Execute SELCT SQL through a DataReader
            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.HasRows)
            {
                //Read the record from database
                while (reader.Read())
                {
                    // Fill staff object with values from the data reader.
                    foodOrder.OrderID = reader.GetString(0);
                    foodOrder.UserID = reader.GetString(1);
                    foodOrder.DelivererID = reader.GetString(2);
                    foodOrder.StoreID = reader.GetString(3);
                    foodOrder.Address = reader.GetString(4);
                    foodOrder.OrderList = reader.GetString(5);
                    foodOrder.Date = reader.GetDateTime(6);
                    foodOrder.OrderConfirm = reader.GetString(7);
                    foodOrder.OrderComplete = reader.GetString(8);
                }
            }
            //Close data reader
            reader.Close();
            //Close database connection
            conn.Close();

            return foodOrder;
        }

        // Get specified FoodOrder and Change Completion
        public void ChangeFoodOrderCompletion(string orderID, string loginID)
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();

            //Specify an UPDATE SQL statement
            cmd.CommandText = @"UPDATE FoodOrder SET OrderComplete = 'Complete' WHERE OrderID = @OrderID";
            //Define the parameters used in SQL statement, value for each parameter
            //is retrieved from respective class's property.
            cmd.Parameters.AddWithValue("@OrderID", orderID);

            //Open a database connection
            conn.Open();
            //ExecuteNonQuery is used for UPDATE and DELETE
            cmd.ExecuteNonQuery();
            //Close the database connection
            conn.Close();
        }

        public void AddFoodOrder(FoodOrder fo)
        {
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();

            //Specify an UPDATE SQL statement
            cmd.CommandText = @"INSERT INTO FoodOrder
                                VALUES (@OrderID, @UserID, @DelivererID, @StoreID, @Address, @OrderList, @Date, @OrderConfirm, @OrderComplete)";
            //Define the parameters used in SQL statement, value for each parameter
            //is retrieved from respective class's property.
            cmd.Parameters.AddWithValue("@OrderID", fo.OrderID);
            cmd.Parameters.AddWithValue("@UserID", fo.UserID);
            cmd.Parameters.AddWithValue("@DelivererID", DBNull.Value);
            cmd.Parameters.AddWithValue("@StoreID", fo.StoreID);
            cmd.Parameters.AddWithValue("@Address", fo.Address);
            cmd.Parameters.AddWithValue("@OrderList", fo.OrderList);
            cmd.Parameters.AddWithValue("@Date", fo.Date);
            cmd.Parameters.AddWithValue("@OrderConfirm", fo.OrderConfirm);
            cmd.Parameters.AddWithValue("@OrderComplete", fo.OrderComplete);

            //Open a database connection
            conn.Open();
            //ExecuteNonQuery is used for UPDATE and DELETE
            cmd.ExecuteNonQuery();
            //Close the database connection
            conn.Close();
        }
    }
}
