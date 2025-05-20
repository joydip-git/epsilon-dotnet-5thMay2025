using Epsilon.DotNet.PmsApp.Entities;

namespace Epsilon.DotNet.PmsApp.Repository
{
    public class ProductDao
    {
        public List<Product> GetAll() 
        { 
            return new List<Product>();
        }
        public Product Get(int id) 
        { 
            return new Product(); 
        }
        public bool Insert(Product p)
        {
            return false;
        }
        public bool Update(int id, Product p)
        {
            return false;
        }
        public bool Delete(int id)
        {
            return false;
        }
    }
}
