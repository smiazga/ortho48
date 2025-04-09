using ortho48.OrthoRepository.PatientDirect.Core.Products;
using System.Collections.Generic;

namespace ortho48.ViewModels
{
    public class ManageProductsViewModel
    {
        public string Message { get; set; }
        public List<Product> ProductsList { get; set; } = new List<Product>();

        public List<Filter> FiltersList { get; set; } = new List<Filter>();
        public List<int> HiddenProductIdsList { get; set; } = new List<int>();
    }
}