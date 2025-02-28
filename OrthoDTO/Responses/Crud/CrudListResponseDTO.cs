using System.Collections.Generic;

namespace ortho48.OrthoDTO.Responses.Crud
{
    public class CrudListResponseDTO : ResultDTO
    {
        public List<CrudDTO> CrudList { get; set; } = new List<CrudDTO>();
    }
}