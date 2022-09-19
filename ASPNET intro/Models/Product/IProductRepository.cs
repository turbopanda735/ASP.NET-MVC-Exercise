namespace ASPNET_intro.Models.Product
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
