using System;
using System.Data.SQLite;

namespace Lab3Examples
{
    class DatabaseInsertSelect
    {
        static void Main()
        {
            string cs = "Data Source=:memory:";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = "CREATE TABLE Employee(Id INTEGER PRIMARY KEY, Name TEXT, Salary REAL)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO Employee(Name, Salary) VALUES('Ram', 60000), ('Shyam', 45000)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT * FROM Employee";
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"Id: {rdr["Id"]}, Name: {rdr["Name"]}, Salary: {rdr["Salary"]}");
            }
        }
    }
}