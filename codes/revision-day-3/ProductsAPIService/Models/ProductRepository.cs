using Microsoft.Data.SqlClient;

namespace ProductsAPIService.Models
{
    public class ProductRepository : IRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string? connectionString;

        public ProductRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("EpsilonDbConStr");
        }

        public Product? Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product? Get(int id)
        {
            SqlConnection? connection = null;
            SqlCommand? command = null;
            SqlDataReader? reader = null;
            try
            {
                connection = new SqlConnection(connectionString);
                command = connection.CreateCommand();
                command.CommandText = "select * from products where productid=@id";
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                reader = command.ExecuteReader();

                Product? product = null;

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        product = new();

                        product.Id = (int)reader["productid"];
                        product.Name = (string)reader["productname"];
                        product.Description = (string)reader["productdesc"];
                        product.Price = (decimal)reader["productprice"];
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
                connection?.Close();
            }
        }

        public List<Product> GetAll()
        {
            SqlConnection? connection = null;
            SqlCommand? command = null;
            SqlDataReader? reader = null;
            List<Product> products = [];
            try
            {
                connection = new SqlConnection(connectionString);
                command = connection.CreateCommand();
                command.CommandText = "select * from products";

                connection.Open();
                reader = command.ExecuteReader();

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new();

                        product.Id = (int)reader["productid"];
                        product.Name = (string)reader["productname"];
                        product.Description = (string)reader["productdesc"];
                        product.Price = (decimal)reader["productprice"];

                        products.Add(product);
                    }
                    reader.Close();
                }
                return products;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection?.Close();
            }
        }

        public Product? Update(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
