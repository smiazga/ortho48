using ortho48.OrthoDTO.Responses;
using ortho48.OrthoRepository.PatientDirect.Core.Products;
using ortho48.OrthoRepository.Services.Managers;
using System.Collections.Generic;
using System.Web.Http;

namespace ortho48.Api.Controllers
{
    [RoutePrefix("sfapi/products")]
    public class ManageProductsApiController : ApiController
    {
        private ProductsManager _productsManager;
        public ManageProductsApiController()
        {
            _productsManager = new ProductsManager();
        }

        [HttpGet]
        [Route("hidden")]
        public IHttpActionResult GetHiddenItems()
        {
            var hiddenIdsList = _productsManager.GetHiddenIdsList();
            return Ok(hiddenIdsList);
        }

        [HttpPost]
        [Route("hidden")]
        public IHttpActionResult HiddenItems(List<HiddenId> hiddenIds)
        {
            var resultDTO = _productsManager.AddHiddenItems(hiddenIds);
            resultDTO.Status = "success";
            return Ok(resultDTO);
        }

        [HttpPost]
        [Route("selectitem")]
        public IHttpActionResult AddSelectedItem([FromBody] int id) //can also use selectitemdto create under ortho48.OrthoDTO.Request
        {
            var resultDTO = _productsManager.AddSelectedItem(id);
            resultDTO.Status = "success";
            //resultDTO.Status = "failed";
            //resultDTO.Message = "Unable to add product.";
            return Ok(resultDTO);
        }

        [HttpDelete]
        [Route("selectitem/{id:int}")]
        public IHttpActionResult DeleteSelectedItem(int id)
        {
            var resultDTO = _productsManager.DeleteSelectedItem(id);
            resultDTO.Status = "success";
            return Ok(resultDTO);
        }

        [HttpPost]
        [Route("selectitems")]
        public IHttpActionResult ModifySelectedItem([FromBody] List<int> ids) //can also use selectitemsdto create under ortho48.OrthoDTO.Request
        {
            ResultDTO resultDTO = new ResultDTO();
            if (ids.Count > 0)
            {
                resultDTO = _productsManager.AddSelectedItems(ids);
            }
            else if (ids.Count == 0)
            {
                resultDTO = _productsManager.RemoveSelectedItems(ids);
            }
            resultDTO.Status = "failed";
            resultDTO.Message = "Unable to add product.";
            return Ok(resultDTO);
        }

    }
}