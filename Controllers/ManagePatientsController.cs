using ortho48.OrthoRepository.Services.Managers;
using ortho48.ViewModels;
using System.Web.Mvc;

namespace ortho48.Controllers
{
    public class ManagePatientsController : Controller
    {
        public string TemplateName { get; set; } = "Index";
        public string Message { get; set; } = "Manage Patients Test";
        public ActionResult Index()
        {
            ManagePatientsViewModel managePatientsViewModel = new ManagePatientsViewModel();
            managePatientsViewModel.Message = Message;

            PatientsManager patientsManager = new PatientsManager();
            managePatientsViewModel.PatientInfoList = patientsManager.GetPatients();

            return View(TemplateName, managePatientsViewModel);
        }
    }
}