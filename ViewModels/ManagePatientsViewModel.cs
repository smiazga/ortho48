using ortho48.OrthoRepository.PatientDirect.Core.Patients;
using System.Collections.Generic;

namespace ortho48.ViewModels
{
    public class ManagePatientsViewModel
    {
        public string Message { get; set; }

        public List<PatientInfo> PatientInfoList { get; set; }
    }
}