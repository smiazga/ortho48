using System.Collections.Generic;

namespace ortho48.OrthoRepository.PatientDirect.Core.Crud
{
    public class CrudsList : Result
    {
        public List<Crud> CrudList { get; set; } = new List<Crud>();
    }
}