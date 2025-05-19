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
    try
    {
        connection = new SqlConnection("");
        //command = connection.CreateCommand();
        command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = "";
        //command.CommandType= CommandType.StoredProcedure;
        //command.Parameters.AddWithValue("",);

        connection.Open();
        //Console.WriteLine(connection.State.ToString());

        //executing SELECT query
        reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Console.WriteLine(reader[""]);
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
