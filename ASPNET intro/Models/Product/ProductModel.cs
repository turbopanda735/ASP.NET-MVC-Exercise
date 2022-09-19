using ASPNET_intro.Models.Category;

namespace ASPNET_intro.Models.Product
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
    }
}
