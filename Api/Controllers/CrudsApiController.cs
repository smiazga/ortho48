using ortho48.OrthoDTO.Responses.Crud;
using ortho48.OrthoRepository.PatientDirect.Core;
using ortho48.OrthoRepository.PatientDirect.Core.Crud;
using ortho48.OrthoRepository.Services.Managers;
using System.Web.Http;

namespace ortho48.Api.Controllers
{
    [RoutePrefix("sfapi/cruds")]
    public class CrudsApiController : ApiController
    {
        private CrudManager _crudManager;
        public CrudsApiController()
        {
            _crudManager = new CrudManager();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetCrud(int id)
        {
            CrudResultDTO crudResultDTO = _crudManager.GetCrud(id);
            Crud crud = new Crud();
            crud.Id = crudResultDTO.Id;
            crud.Text = crudResultDTO.Text;
            crud.UserId = crudResultDTO.UserId;
            crud.Status = crudResultDTO.Status;
            crud.Error = crudResultDTO.Error;
            crud.Message = crudResultDTO.Message;
            return Ok(crud);
        }

        //[HttpGet]
        //[Route("{id:int}")]
        //public async Task<IHttpActionResult> GetCrud2(int id)
        //{
        //    CrudResultDTO crudResultDTO = await Task.Run(() => _crudManager.GetCrud(id));
        //    Crud2 crud = new Crud2();
        //    crud.Id = crudResultDTO.Id;
        //    crud.Text = crudResultDTO.Text;
        //    crud.UserId = crudResultDTO.UserId;
        //    crud.Status = crudResultDTO.Status;
        //    crud.Error = crudResultDTO.Error;
        //    crud.Message = crudResultDTO.Message;
        //    return Ok(crud);
        //}

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllCruds()
        {
            CrudsList crudsList = new CrudsList();
            CrudListResponseDTO crudListDTO = _crudManager.GetAllCruds();
            foreach (var c in crudListDTO.CrudList)
            {
                Crud crud = new Crud();
                crud.Id = c.Id;
                crud.Text = c.Text;
                crud.UserId = c.UserId;

                crudsList.CrudList.Add(crud);
            }
            crudsList.Status = crudListDTO.Status;
            crudsList.Message = crudListDTO.Message;
            crudsList.Error = crudListDTO.Error;
            return Ok(crudsList);
        }

        [HttpPost]
        public IHttpActionResult CreateCrud(Crud crud)
        {
            CrudDTO crudDTO = new CrudDTO();
            crudDTO.Id = crud.Id;
            crudDTO.Text = crud.Text;
            crudDTO.UserId = crud.UserId;
            var resultDTO = _crudManager.CreateCrud(crudDTO);
            crud.Status = resultDTO.Status;
            crud.Error = resultDTO.Error;
            crud.Message = resultDTO.Message;

            return CreatedAtRoute(nameof(GetCrud), new { id = crud.Id }, crud);

        }

        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult UpdateCrud(int id, Crud crud)
        {
            CrudDTO crudDTO = new CrudDTO();
            crudDTO.Id = crud.Id;
            crudDTO.Text = crud.Text;
            crudDTO.UserId = crud.UserId;

            if (id != crud.Id)
            {
                return BadRequest();
            }

            var resultDTO = _crudManager.UpdateCrud(id, crudDTO);
            Result result = new Result();
            result.Status = resultDTO.Status;
            result.Message = resultDTO.Message;
            result.Error = resultDTO.Error;
            if (resultDTO == null)
            {
                return NotFound();
            }

            return Ok(crud);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult DeleteCrud(int id)
        {
            var crudDTO = _crudManager.GetCrud(id);
            Crud crud = new Crud();
            crud.Id = crudDTO.Id;
            crud.Text = crudDTO.Text;
            crud.UserId = crudDTO.UserId;
            crud.Status = crudDTO.Status;
            crud.Error = crudDTO.Error;
            crud.Message = crudDTO.Message;

            if (crud.Id != id)
            {
                return NotFound();
            }

            var resultDTO = _crudManager.DeleteCrud(id);
            Result result = new Result();
            result.Status = resultDTO.Status;
            result.Message = resultDTO.Message;
            result.Error = resultDTO.Error;

            return Ok(result);
        }

        [HttpGet]
        [Route("user/{userId:int}")]
        public IHttpActionResult GetCrudsByUserId(int userId)
        {
            CrudsList crudsList = new CrudsList();
            CrudListResponseDTO crudListDTO = _crudManager.GetCrudByUserId(userId);
            foreach (var c in crudListDTO.CrudList)
            {
                Crud crud = new Crud();
                crud.Id = c.Id;
                crud.Text = c.Text;
                crud.UserId = c.UserId;

                crudsList.CrudList.Add(crud);
            }
            crudsList.Status = crudListDTO.Status;
            crudsList.Message = crudListDTO.Message;
            crudsList.Error = crudListDTO.Error;
            return Ok(crudsList);
        }
    }
}