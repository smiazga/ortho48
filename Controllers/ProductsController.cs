using ortho48.OrthoRepository.PatientDirect.Core.Products;
using ortho48.OrthoRepository.Services.Managers;
using ortho48.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using Filter = ortho48.OrthoRepository.PatientDirect.Core.Products.Filter;

namespace ortho48.Controllers
{
    public class ProductsController : Controller
    {
        public string TemplateName { get; set; } = "Index";
        public string Message { get; set; } = "Products Test";
        public ActionResult Index()
        {
            ManageProductsViewModel productsViewModel = new ManageProductsViewModel();
            productsViewModel.Message = Message;

            ProductsManager productsManager = new ProductsManager();
            List<Product> productsList = productsManager.GetAllProducts();
            List<Filter> filtersList = productsManager.GetAllFilters();
            productsViewModel.FiltersList = filtersList;
            productsViewModel.ProductsList = productsList;

            return View(TemplateName, productsViewModel);
        }
    }
}