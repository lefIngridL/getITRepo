using System;
using System.IO;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace JsonImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the JSON file
            string jsonString = File.ReadAllText(@"path\to\your\file.json");

            // Deserialize the JSON data
            var data = JsonConvert.DeserializeObject<List<YourClass>>(jsonString);

            // Connect to the SQL Server database
            string connectionString = "your connection string here";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Create a new table
                string createTableQuery = "CREATE TABLE NewTable (Column1 DataType, Column2 DataType, ...)";
                using (SqlCommand cmd = new SqlCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // Insert the data into the new table
                string insertQuery = "INSERT INTO NewTable (Column1, Column2, ...) VALUES (@Value1, @Value2, ...)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    foreach (var item in data)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Value1", item.Property1);
                        cmd.Parameters.AddWithValue("@Value2", item.Property2);
                        // Add more parameters as needed
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }

    public class YourClass
    {
        public PropertyType Property1 { get; set; }
        public PropertyType Property2 { get; set; }
        // Define more properties as needed
    }
}
