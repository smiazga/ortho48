using ortho48.OrthoRepository.PatientDirect.Core.Products;
using System.Collections.Generic;

namespace ortho48.OrthoRepository.Services.Managers
{
    public class ProductsManager
    {
        public List<Product> GetAllProducts()
        {
            ProductsProcess productsProcess = new ProductsProcess();
            var productsList = productsProcess.GetAllProducts();
            return productsList;
        }

        public List<Filter> GetAllFilters()
        {
            ProductsProcess productsProcess = new ProductsProcess();
            var filtersList = productsProcess.GetAllFilters();
            return filtersList;
        }

        public List<int> GetAllVisibleItems()
        {
            ProductsProcess productsProcess = new ProductsProcess();
            var visibleItems = productsProcess.GetVisibleItems();
            return visibleItems;
        }

    }
}