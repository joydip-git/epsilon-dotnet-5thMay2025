// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

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
	SqlConnection sqlConnection = null;
	SqlCommand sqlCommand = null;
	SqlDataReader sqlDataReader = null;
	try
	{
		sqlConnection = new SqlConnection("connection string"); 
		sqlCommand = sqlConnection.CreateCommand();
		sqlCommand.CommandText = "query";

		sqlConnection.Open();
		//if the query is "SELECT"
		sqlDataReader = sqlCommand.ExecuteReader();
		if(sqlDataReader != null && sqlDataReader.HasRows)
		{
			while (sqlDataReader.Read()) 
			{
				var data = sqlDataReader["column-name/col-index"];
                Console.WriteLine(data);
			}
			sqlDataReader.Close();
		}
	}
	catch(SqlException)
	{
		throw;
	}
	catch (NullReferenceException) 
	{
		throw;
	}
	catch(ArgumentException)
	{
		throw;
	}
	catch (Exception)
	{
		throw;
	}
	finally
	{
		if(sqlConnection != null)
			sqlConnection.Close();
	}
}
