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
    public class ReviewDAL
    {
        private IConfiguration Configuration { get; set; }
        private SqlConnection conn;

        //Constructor
        public ReviewDAL()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string strConn = Configuration.GetConnectionString(
            "HCConnectionString");
            conn = new SqlConnection(strConn);
        }

        // GET all reviews from specified store
        public List<Review> GetAllReviews(string storeId)
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM Review WHERE StoreID = @selectedStoreID";

            cmd.Parameters.AddWithValue("@selectedStoreID", storeId);

            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();

            List<Review> reviewList = new List<Review>();
            while (reader.Read())
            {
                reviewList.Add(
                new Review
                {
                    UserID = reader.GetString(0),
                    ReviewID = reader.GetString(1),
                    StoreID = reader.GetString(2),
                    Description = reader.GetString(3),
                    Rating = reader.GetInt32(4),
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();
            return reviewList;
        }

    }
}
