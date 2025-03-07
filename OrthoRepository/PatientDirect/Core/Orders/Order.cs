using System.Collections.Generic;

namespace ortho48.OrthoRepository.PatientDirect.Core.Orders
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string OrderDate { get; set; } //can change to datetime put formatting here for now
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}