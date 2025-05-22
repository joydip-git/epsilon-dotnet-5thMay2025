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

        public List<Product> FilterByName(string name)
        {
            try
            {
                var products = productDao.GetAll();
                //return products.Where(p=> p.ProductName.Contains(name)).ToList();
                return [.. products.Where(p => p.ProductName.Contains(name))];
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Product> FetchAllAndSort(int choice = 1)
        {
            try
            {
                List<Product> products = productDao.GetAll();
                List<Product> result = null;
                switch (choice)
                {
                    case 1:
                        result = products.OrderBy(p => p.ProductId).ToList();
                        break;

                    case 2:
                        result =
                            [..
                                products.OrderBy(p => p.ProductName)
                            ];
                        break;

                    case 3:
                        result = [.. products.OrderBy(p => p.Price)];
                        break;

                    default:
                        result = [.. products.OrderBy(p => p.ProductId)];
                        break;
                }
                return products;
            }
            catch (Exception)
            {
                throw;
            }
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
