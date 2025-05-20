using Epsilon.DotNet.PmsApp.Entities;
using Epsilon.DotNet.PmsApp.Repository;

namespace Epsilon.DotNet.PmsApp.BusinessLogic
{
    public class ProductBusinessComponent
    {
        private ProductDao productDao;

        public ProductBusinessComponent()
        {
            productDao = new ProductDao();
        }

        public List<Product> FetchAll(int choice)
        {
            return [];
        }
        public Product Fetch(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException($"value of {nameof(id)} can't be negative or zero");

                return productDao.Get(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Add(Product product)
        {
            try
            {
                if (product == null || string.IsNullOrEmpty(product.ProductName))
                    throw new ArgumentException($"the {nameof(product)} is invalid");
                return productDao.Insert(product);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Modify(int id, Product product)
        {
            try
            {
                if (product == null || string.IsNullOrEmpty(product.ProductName))
                    throw new ArgumentException($"the {nameof(product)} is invalid");

                if (id <= 0)
                    throw new ArgumentException($"value of {nameof(id)} can't be negative or zero");

                return productDao.Update(id, product);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Remove(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException($"value of {nameof(id)} can't be negative or zero");
                return productDao.Delete(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
