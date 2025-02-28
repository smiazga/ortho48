using System.Collections.Generic;

namespace ortho48.OrthoRepository.PatientDirect.Core.Products
{
    public class Filter
    {
        public string CategoryName { get; set; }
        public List<FilterValue> FilterValues { get; set; }
        public Filter()
        {
            this.FilterValues = new List<FilterValue>();
        }
    }

    public class FilterValue
    {
        public string Name { get; set; }
    }
}