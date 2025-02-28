namespace ortho48.OrthoRepository.PatientDirect.Core.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductUrl { get; set; }
        public string Sku { get; set; }
        public string ImageUrl { get; set; }
        public string MainCategories { get; set; }
        public string AllCategories { get; set; }
        public decimal Price { get; set; }
        public bool Favorite { get; set; }
    }
}