using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static string connectionString = "Data Source=localhost;Initial Catalog=YourDatabase;Integrated Security=True";

    static void Main()
    {
        InsertEmployee("John", "HR");
        ReadEmployees();
        UpdateEmployee(1, "Finance");
        DeleteEmployee(1);
    }

    static void InsertEmployee(string name, string dept)
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand("INSERT INTO Employees (Name, Department) VALUES (@name, @dept)", conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@dept", dept);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Inserted employee.");
    }

    static void ReadEmployees()
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Department: {reader["Department"]}");
        }
        reader.Close();
    }

    static void UpdateEmployee(int id, string newDept)
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand("UPDATE Employees SET Department = @dept WHERE Id = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@dept", newDept);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Updated employee.");
    }

    static void DeleteEmployee(int id)
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE Id = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
        Console.WriteLine("Deleted employee.");
    }
}
