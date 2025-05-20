using Epsilon.DotNet.PmsApp.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Epsilon.DotNet.PmsApp.Repository
{
    public class ProductDao
    {
        private string connectionString;

        public ProductDao()
        {
            connectionString = @"server=.\sqlexpress; database=epsilondatabase; integrated security=true; trustservercertificate=true; encrypt=false";
        }

        public List<Product> GetAll()
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            List<Product> products = null;
            try
            {
                connection = new SqlConnection(connectionString);
                command = connection.CreateCommand();
                command.CommandText = "select * from products";

                connection.Open();
                reader = command.ExecuteReader();
                if (reader != null && reader.HasRows)
                {
                    products = new List<Product>();

                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            ProductId = (int)reader["productid"],
                            ProductName = (string)reader["productname"],
                            ProductDescription = (string)reader["productdesc"],
                            Price = (decimal)reader["productprice"]
                        };
                        products.Add(product);
                    }
                }
                return products;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
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
        public Product Get(int id)
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            Product product = null;
            try
            {
                connection = new SqlConnection(connectionString);
                command = connection.CreateCommand();
                command.CommandText = "select * from products where productid=@id";
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                reader = command.ExecuteReader();
                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product = new Product
                        {
                            ProductId = (int)reader["productid"],
                            ProductName = (string)reader["productname"],
                            ProductDescription = (string)reader["productdesc"],
                            Price = (decimal)reader["productprice"]
                        };
                    }
                }
                return product;
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
        public bool Insert(Product p)
        {
            try
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Update(int id, Product p)
        {
            try
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
