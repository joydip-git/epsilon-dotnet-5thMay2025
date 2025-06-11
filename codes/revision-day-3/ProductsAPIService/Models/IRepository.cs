namespace ProductsAPIService.Models
{
    public interface IRepository
    {
        List<Product> GetAll();
        Product? Get(int id);
        Product? Add(Product product);
        Product? Update(int id, Product product);
        Product? Delete(int id);
    }
}
