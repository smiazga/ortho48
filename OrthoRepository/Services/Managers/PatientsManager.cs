using ortho48.OrthoRepository.PatientDirect.Core;
using ortho48.OrthoRepository.PatientDirect.Core.Orders;
using ortho48.OrthoRepository.PatientDirect.Core.Patients;
using System;
using System.Collections.Generic;

namespace ortho48.OrthoRepository.Services.Managers
{
    public class PatientsManager
    {
        public List<PatientInfo> GetPatients()
        {
            PatientProcess patientProcess = new PatientProcess(); //patientprocessor
            var patientsList = patientProcess.GetAllPatientInfo();
            return patientsList;
        }

        public PatientDetails GetPatientDetails(int customerId)
        {
            PatientProcess patientProcess = new PatientProcess();
            var patientDetails = patientProcess.GetPatientDetails(customerId);
            return patientDetails;
        }

        public List<Order> GetOrders(int customerId)
        {
            PatientProcess patientProcess = new PatientProcess();
            var patientOrdersList = patientProcess.GetOrdersByPatient(customerId);
            return patientOrdersList;
        }

        public List<Subscription> GetSubscriptions(int customerId)
        {
            PatientProcess patientProcess = new PatientProcess();
            var patientSubscriptionsList = patientProcess.GetSubscriptionsByPatient(customerId);
            return patientSubscriptionsList;
        }

        public Result UpdatePatientDetail(int customerId, PatientDetails patientDetails)
        {
            Result result = new Result();
            try
            {
                PatientProcess patientProcess = new PatientProcess();
                patientProcess.UpdatePatientDetails(customerId, patientDetails);
                result.Status = "success";
                return result;
            }
            catch (Exception ex)
            {
                result.Status = "failed";
                result.Error = ex.Message.ToString();
                return result;
            }
        }

        public Result CreatePatientInfo(PatientInfo patientInfo)
        {
            Result result = new Result();
            try
            {
                //PatientProcess patientProcess = new PatientProcess();
                //patientProcess.AddPatientInfo(patientInfo);
                result.Status = "success";
                return result;
            }
            catch (Exception ex)
            {
                result.Status = "failed";
                result.Error = ex.Message.ToString();
                return result;
            }
        }

    }
}