using ASPNET_intro.Models.Category;

namespace ASPNET_intro.Models.Product
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public void DeleteProduct(Product product);
        public IEnumerable<CategoryModel> GetCategories();
        public Product AssignCategory();

    }
}
