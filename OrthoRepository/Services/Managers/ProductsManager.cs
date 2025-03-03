using ortho48.OrthoDTO.Responses;
using ortho48.OrthoRepository.PatientDirect.Core.Products;
using System;
using System.Collections.Generic;

namespace ortho48.OrthoRepository.Services.Managers
{
    public class ProductsManager
    {
        public List<Product> GetAllProducts()
        {
            ProductsProcess productsProcess = new ProductsProcess();
            var productsList = productsProcess.GetAllProducts();
            return productsList;
        }

        public List<Filter> GetAllFilters()
        {
            ProductsProcess productsProcess = new ProductsProcess();
            var filtersList = productsProcess.GetAllFilters();
            return filtersList;
        }

        public List<int> GetAllSelectItems()
        {
            ProductsProcess productsProcess = new ProductsProcess();
            var visibleItems = productsProcess.GetSelectItems();
            return visibleItems;
        }

        public ResultDTO AddSelectedItem(int id)
        {
            ResultDTO resultDTO = new ResultDTO();
            try
            {

                resultDTO.Status = "success";
                return resultDTO;
            }
            catch (Exception ex)
            {
                resultDTO.Status = "failed";
                resultDTO.Error = ex.Message.ToString();
                return resultDTO;
            }
        }

        public ResultDTO AddSelectedItems(List<int> ids)
        {
            ResultDTO resultDTO = new ResultDTO();
            try
            {

                resultDTO.Status = "success";
                return resultDTO;
            }
            catch (Exception ex)
            {
                resultDTO.Status = "failed";
                resultDTO.Error = ex.Message.ToString();
                return resultDTO;
            }
        }

        public ResultDTO RemoveSelectedItems(List<int> ids)
        {
            ResultDTO resultDTO = new ResultDTO();
            try
            {

                resultDTO.Status = "success";
                return resultDTO;
            }
            catch (Exception ex)
            {
                resultDTO.Status = "failed";
                resultDTO.Error = ex.Message.ToString();
                return resultDTO;
            }
        }

        public ResultDTO DeleteSelectedItem(int Id)
        {
            ResultDTO resultDTO = new ResultDTO();
            try
            {


                resultDTO.Status = "success";
                return resultDTO;
            }
            catch (Exception ex)
            {
                resultDTO.Status = "failed";
                resultDTO.Error = ex.Message.ToString();
                return resultDTO;
            }
        }

    }
}