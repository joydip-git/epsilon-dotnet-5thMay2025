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
            SqlConnection connection = null;
            SqlCommand command = null;
            try
            {
                connection = new SqlConnection(connectionString);
                command = connection.CreateCommand();
                command.CommandText = "insert into products(productname,productdesc,productprice) values(@name,@desc,@price)";
                command.Parameters.AddWithValue("@name", p.ProductName);
                command.Parameters.AddWithValue("@desc", p.ProductDescription);
                command.Parameters.AddWithValue("@price", p.Price);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0 ? true : false;
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
        public bool Update(int id, Product p)
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            try
            {
                Product found = Get(id);
                if (found != null)
                {
                    connection = new SqlConnection(connectionString);
                    command = connection.CreateCommand();
                    command.CommandText = "update products set productname=@name,productdesc=@desc,productprice=@price where productid=@id";
                    command.Parameters.AddWithValue("@name", p.ProductName);
                    command.Parameters.AddWithValue("@desc", p.ProductDescription);
                    command.Parameters.AddWithValue("@price", p.Price);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0 ? true : false;
                }
                else
                    throw new Exception($"the product with id:{id} does not exist");
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
        public bool Delete(int id)
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            try
            {
                Product p = Get(id);
                if (p != null)
                {
                    connection = new SqlConnection(connectionString);
                    command = connection.CreateCommand();
                    command.CommandText = "delete from products where productid=@id";
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0 ? true : false;
                }
                else
                    throw new Exception($"the product with id:{id} does not exist");
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
    }
}
