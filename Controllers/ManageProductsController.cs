using ortho48.OrthoRepository.Services.Managers;
using ortho48.ViewModels;
using System.Web.Mvc;

namespace ortho48.Controllers
{
    public class ManageProductsController : Controller
    {
        public string TemplateName { get; set; } = "Index";
        public string Message { get; set; } = "Manage Products Test";
        public ActionResult Index()
        {
            ManageProductsViewModel productsViewModel = new ManageProductsViewModel();
            productsViewModel.Message = Message;

            ProductsManager productsManager = new ProductsManager();
            productsViewModel.ProductsList = productsManager.GetAllProducts();
            productsViewModel.FiltersList = productsManager.GetAllFilters();
            productsViewModel.HiddenProductIdsList = productsManager.GetHiddenIdsList();

            return View(TemplateName, productsViewModel);
        }
    }
}