using ortho48.OrthoRepository.PatientDirect.Core.Products;
using System.Collections.Generic;

namespace ortho48.ViewModels
{
    public class ProductsViewModel
    {
        public string Message { get; set; }
        public List<Product> ProductsList { get; set; } = new List<Product>();

        public List<Filter> FiltersList { get; set; } = new List<Filter>();
    }
}