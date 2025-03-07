namespace ortho48.OrthoRepository.PatientDirect.Core.Patients
{
    public class PatientInfo
    {
        public int CustomerId { get; set; }
        public string PatientInitials { get; set; }
        public string PatientName { get; set; }
        public string PatientEmail { get; set; }
        public string DateRegistered { get; set; }
        public int OrdersCount { get; set; }
        public int SubscriptionsCount { get; set; }

    }
}