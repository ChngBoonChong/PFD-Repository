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
    public class HawkerStoreDAL
    {
        private IConfiguration Configuration { get; set; }
        private SqlConnection conn;

        //Constructor
        public HawkerStoreDAL()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string strConn = Configuration.GetConnectionString(
            "HCConnectionString");
            conn = new SqlConnection(strConn);
        }

        public List<HawkerStore> GetAllStores()
        {

            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement
            cmd.CommandText = @"SELECT * FROM HawkerStore ORDER BY StoreID";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();

            List<HawkerStore> storeList = new List<HawkerStore>();
            while (reader.Read())
            {
                storeList.Add(
                new HawkerStore
                {
                    CentreID = reader.GetString(0), //0: 1st column
                    StoreID = reader.GetString(1),
                    AVGRating = reader.GetInt32(2),
                    Name = reader.GetString(3),
                }
                );
            }
            //Close DataReader
            reader.Close();
            //Close the database connection
            conn.Close();
            return storeList;
        }

        public HawkerStore GetDetails(string storeId)
        {
            HawkerStore store = new HawkerStore();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT * FROM HawkerStore                       
                                WHERE StoreID = @selectedStoreID";

            cmd.Parameters.AddWithValue("@selectedStoreID", storeId);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    store.StoreID = storeId;
                    store.CentreID = !reader.IsDBNull(0) ? reader.GetString(0) : null;
                    store.AVGRating = reader.GetInt32(2);
                    store.Name = !reader.IsDBNull(3) ? reader.GetString(3) : null;
                }
            }
            reader.Close();
            conn.Close();

            return store;
        }
    }
}
