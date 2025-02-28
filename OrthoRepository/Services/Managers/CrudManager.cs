using ortho48.OrthoDTO.Responses;
using ortho48.OrthoDTO.Responses.Crud;
using ortho48.OrthoRepository.PatientDirect.Core.Crud;
using System;

namespace ortho48.OrthoRepository.Services.Managers
{
    public class CrudManager
    {
        public CrudListResponseDTO GetAllCruds()
        {
            CrudListResponseDTO crudListResponseDTO = new CrudListResponseDTO();
            try
            {
                CrudProcess crudProcess = new CrudProcess();
                var crudList = crudProcess.GetAllCruds();
                foreach (var item in crudList)
                {
                    CrudDTO crudDTO = new CrudDTO()
                    {
                        Id = item.Id,
                        Text = item.Text,
                        UserId = item.UserId
                    };
                    crudListResponseDTO.CrudList.Add(crudDTO);
                }
                crudListResponseDTO.Status = "success";
                return crudListResponseDTO;
            }
            catch (Exception ex)
            {
                crudListResponseDTO.Status = "failed";
                //log?
                crudListResponseDTO.Error = ex.Message.ToString();
                return crudListResponseDTO;
            }
        }

        public CrudResultDTO GetCrud(int id)
        {
            CrudResultDTO crudResultDTO = new CrudResultDTO();
            try
            {
                CrudProcess crudProcess = new CrudProcess();
                var crud = crudProcess.GetCrud(id);
                crudResultDTO.Id = crud.Id;
                crudResultDTO.Text = crud.Text;
                crudResultDTO.UserId = crud.UserId;
                crudResultDTO.Status = "success";

                return crudResultDTO;
            }
            catch (Exception ex)
            {
                crudResultDTO.Status = "failed";
                //log?
                crudResultDTO.Error = ex.Message.ToString();
                return crudResultDTO;
            }
        }

        public CrudListResponseDTO GetCrudByUserId(int userId)
        {
            CrudListResponseDTO crudListResponseDTO = new CrudListResponseDTO();
            try
            {
                CrudProcess crudProcess = new CrudProcess();
                var crudList = crudProcess.GetCrudsByUserId(userId);
                foreach (var item in crudList)
                {
                    CrudDTO crudDTO = new CrudDTO()
                    {
                        Id = item.Id,
                        Text = item.Text,
                        UserId = item.UserId
                    };
                    crudListResponseDTO.CrudList.Add(crudDTO);
                }
                crudListResponseDTO.Status = "success";
                return crudListResponseDTO;
            }
            catch (Exception ex)
            {
                crudListResponseDTO.Status = "failed";
                //log?
                crudListResponseDTO.Error = ex.Message.ToString();
                return crudListResponseDTO;
            }
        }

        public ResultDTO CreateCrud(CrudDTO crudDTO)
        {
            ResultDTO resultDTO = new ResultDTO();
            try
            {
                Crud crud = new Crud();
                crud.Id = crudDTO.Id;
                crud.Text = crudDTO.Text;
                crud.UserId = crudDTO.UserId;
                CrudProcess crudProcess = new CrudProcess();
                crudProcess.CreateCrud(crud);

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

        public ResultDTO UpdateCrud(int id, CrudDTO crudDTO)
        {
            ResultDTO resultDTO = new ResultDTO();
            try
            {
                CrudProcess crudProcess = new CrudProcess();
                Crud crud = new Crud();
                crud.Id = crudDTO.Id;
                crud.Text = crudDTO.Text;
                crud.UserId = crudDTO.UserId;
                crudProcess.UpdateCrud(id, crud);

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

        public ResultDTO DeleteCrud(int id)
        {
            ResultDTO resultDTO = new ResultDTO();
            try
            {
                CrudProcess crudProcess = new CrudProcess();
                crudProcess.DeleteCrud(id);
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