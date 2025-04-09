using System.Collections.Generic;

namespace ortho48.OrthoRepository.PatientDirect.Core.Products
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string MainCategories { get; set; }
        public string AllCategories { get; set; }
        public decimal SortPrice { get; set; }
        public int SortSize { get; set; }
        public List<string> SizePriceList { get; set; }
        public bool Hidden { get; set; }
    }
}