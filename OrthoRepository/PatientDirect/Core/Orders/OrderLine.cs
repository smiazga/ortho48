namespace ortho48.OrthoRepository.PatientDirect.Core.Orders
{
    public class OrderLine
    {
        public int OrderId { get; set; }
        public string ProductUrl { get; set; }
        public string ProductName { get; set; }
        public string Size { get; set; }
        public int OrderQuantity { get; set; }
        public decimal Price { get; set; }
    }
}