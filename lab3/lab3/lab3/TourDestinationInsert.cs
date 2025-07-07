using System;
using System.Data.SQLite;

namespace Lab3Examples
{
    class TourDestinationInsert
    {
        static void Main()
        {
            string cs = "Data Source=:memory:";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = @"CREATE TABLE [TourDestination](
                Id INTEGER PRIMARY KEY,
                Title TEXT,
                Description TEXT,
                Duration INTEGER,
                CreatedDate TEXT
            )";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO [TourDestination](Title, Description, Duration, CreatedDate) VALUES('Pokhara', 'Beautiful city with lakes', 3, '2024-06-01'), ('Kathmandu', 'Capital city of Nepal', 2, '2024-06-02')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT * FROM [TourDestination]";
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"Id: {rdr["Id"]}, Title: {rdr["Title"]}, Description: {rdr["Description"]}, Duration: {rdr["Duration"]}, CreatedDate: {rdr["CreatedDate"]}");
            }
        }
    }
} 