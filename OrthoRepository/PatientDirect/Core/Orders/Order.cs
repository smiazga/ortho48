using System;
using System.Collections.Generic;

namespace ortho48.OrthoRepository.PatientDirect.Core.Orders
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; } //can change to datetime put formatting here for now
        public decimal OrderTotal { get; set; }
        public string OrderProducts { get; set; }
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}