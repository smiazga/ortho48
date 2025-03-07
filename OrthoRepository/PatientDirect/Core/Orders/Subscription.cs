using System.Collections.Generic;

namespace ortho48.OrthoRepository.PatientDirect.Core.Orders
{
    public class Subscription
    {
        public int ShipmentOrderId { get; set; }
        public int CustomerId { get; set; }
        public string NextOrderDate { get; set; } //can change to datetime put formatting here for now
        public string Frequency { get; set; }
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}