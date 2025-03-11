using ortho48.OrthoRepository.PatientDirect.Core.Patients;
using ortho48.OrthoRepository.Services.Managers;
using System.Web.Http;

namespace ortho48.Api.Controllers
{
    [RoutePrefix("sfapi/patients")]
    public class ManagePatientsApiController : ApiController
    {
        private PatientsManager _patientsManager;
        public ManagePatientsApiController()
        {
            _patientsManager = new PatientsManager();
        }

        [HttpGet]
        [Route("info")]
        public IHttpActionResult GetPatientInfo()
        {
            var patientsList = _patientsManager.GetPatients();
            return Ok(patientsList);
        }

        [HttpGet]
        [Route("details/{customerId:int}")]
        public IHttpActionResult GetPatientDetails(int customerId)
        {
            var patientDetails = _patientsManager.GetPatientDetails(customerId);
            return Ok(patientDetails);
        }

        [HttpGet]
        [Route("orders/{customerId:int}")]
        public IHttpActionResult GetPatientOrders(int customerId)
        {
            var patientOrders = _patientsManager.GetOrders(customerId);
            return Ok(patientOrders);
        }

        [HttpGet]
        [Route("subscriptions/{customerId:int}")]
        public IHttpActionResult GetPatientSubscriptions(int customerId)
        {
            var patientSubscriptions = _patientsManager.GetSubscriptions(customerId);
            return Ok(patientSubscriptions);
        }

        [HttpPut]
        [Route("details/{customerId:int}")]
        public IHttpActionResult UpdatePatientDetails(int customerId, PatientDetails patientDetails)
        {
            var result = _patientsManager.UpdatePatientDetail(customerId, patientDetails);
            return Ok(result);
        }

        [HttpPost]
        [Route("info")]
        public IHttpActionResult CreatePatientInfo(PatientInfo patientInfo)
        {
            var result = _patientsManager.CreatePatientInfo(patientInfo);
            return Ok(result);
        }

    }
}