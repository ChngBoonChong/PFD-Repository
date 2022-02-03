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
    public class HawkerCentreDAL
    {
        private IConfiguration Configuration { get; set; }
        private SqlConnection conn;

        //Constructor
        public HawkerCentreDAL()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string strConn = Configuration.GetConnectionString(
            "HCConnectionString");
            conn = new SqlConnection(strConn);
        }

        // Get specific hawker centre details
        public HawkerCentre GetHawkerCentreDetails(string centreID)
        {
            HawkerCentre hawkerCentre = new HawkerCentre();

            // Retrieve the updated details of the specified order
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = @"SELECT * FROM HawkerCentre WHERE CentreID = @CentreID";

            cmd.Parameters.AddWithValue("@CentreID", centreID);

            //Open a database connection
            conn.Open();
            //Execute SELCT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //Read the record from database
                while (reader.Read())
                {
                    // Fill hawkercentre object with values from the data reader.
                    hawkerCentre.CentreID = reader.GetString(0);
                    hawkerCentre.Name = reader.GetString(1);
                    hawkerCentre.Address = reader.GetString(2);
                }
            }
            //Close data reader
            reader.Close();
            //Close database connection
            conn.Close();

            return hawkerCentre;
        }
    }
}
