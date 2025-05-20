namespace Epsilon.DotNet.PmsApp.Entities
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int id, string name, string description, decimal price)
        {
            ProductId = id;
            ProductName = name;
            ProductDescription = description;
            Price = price;
        }

        public int ProductId { set; get; }

        //property setter
        public string ProductName { set; get; } = string.Empty;

        public string ProductDescription { set; get; } = string.Empty;

        public decimal Price { set; get; }

        public override bool Equals(object? obj)
        {
            return obj != null && obj is Product other &&
                   this.ProductId == other.ProductId;
        }

        public override int GetHashCode()
        {
            const int prime = 31;
            return HashCode.Combine(ProductId) ^ prime;
        }

        public override string? ToString()
        {
            return $"[Id={ProductId}, Name={ProductName}, Description={ProductDescription}, Price={Price}]";
        }
    }
}
