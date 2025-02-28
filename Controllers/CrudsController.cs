using ortho48.OrthoDTO.Responses.Crud;
using ortho48.OrthoRepository.PatientDirect.Core.Crud;
using ortho48.OrthoRepository.Services.Managers;
using ortho48.ViewModels;
using System.Web.Mvc;

namespace ortho48.Controllers
{
    public class CrudsController : Controller
    {
        public string TemplateName { get; set; } = "Default";
        public string Message { get; set; } = "Cruds Test";
        public string CssClass { get; set; }
        public ActionResult Index()
        {
            CrudsViewModel crudsViewModel = new CrudsViewModel();
            crudsViewModel.Message = Message;

            CrudsList crudsList = new CrudsList();
            CrudManager crudManager = new CrudManager();
            CrudListResponseDTO crudListDTO = crudManager.GetAllCruds();
            foreach (var c in crudListDTO.CrudList)
            {
                Crud crud = new Crud();
                crud.Id = c.Id;
                crud.Text = c.Text;
                crud.UserId = c.UserId;

                crudsList.CrudList.Add(crud);
            }
            crudsList.Status = crudListDTO.Status;
            crudsList.Message = crudListDTO.Message;
            crudsList.Error = crudListDTO.Error;
            crudsViewModel.CrudsList = crudsList;

            return View(TemplateName, crudsViewModel);
        }
    }
}