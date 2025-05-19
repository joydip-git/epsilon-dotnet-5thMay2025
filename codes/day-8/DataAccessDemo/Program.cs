// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using System.Data;

Console.WriteLine("Welcome to Data Access");
try
{
    GetData();
}
catch (SqlException ex)
{
    Console.WriteLine(ex);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

static void GetData()
{
    SqlConnection connection = null;
    SqlCommand command = null;
    SqlDataReader reader = null;
    string connectionString = @"server=.\sqlexpress;database=epsilondatabase;integrated security=true;TrustServerCertificate=true";
    string query = "select * from products";
    try
    {
        connection = new SqlConnection(connectionString);
        //command = connection.CreateCommand();
        command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = query;
        //command.CommandType = CommandType.Text;
        //command.CommandType= CommandType.StoredProcedure;
        //command.Parameters.AddWithValue("",);

        connection.Open();
        Console.WriteLine(connection.State.ToString());

        //executing SELECT query
        reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                //Console.Write((int)reader["productid"]);
                //Console.Write("\t" + (string)reader["productname"]);
                //Console.Write("\t" + (string)reader["productdesc"]);
                //Console.Write("\t" + (decimal)reader["productprice"] + "\n");
                Console.Write(reader.GetInt32("productid")+"\t");
                Console.Write(reader.GetValue("productname") + "\t");
                Console.Write(reader.GetFieldValue<decimal>("productprice") + "\t");
                Console.Write(reader["productdesc"] + "\n");
            }
        }
    }
    catch (Exception)
    {
        throw;
    }
    finally
    {
        if (connection != null && connection.State == ConnectionState.Open)
            connection.Close();
    }
}
