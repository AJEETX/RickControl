using app.Core;
using app.Core.Service;
using app.Domain;
using app.Message;
using app.Model.Domain;
using app.Model.Service;
using app.Service.Base;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Service.CaseStatus
{
    public class CaseStatusService : BaseService, ICaseStatusService
    {
        public CaseStatusService(IUnitOfWorks unitOfWorks, IMapper mapper) : base(unitOfWorks, mapper)
        {
            
        }
        public async Task<ServiceResult> AddAsync(CaseStatusDTO model)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                using (_unitOfWork)
                {
                    Data.Entity.CaseStatus entity = _mapper.Map<Data.Entity.CaseStatus>(model);
                    entity.CreateDate = DateTime.Now;
                    await _unitOfWork.ClaimStatusRepository.AddAsync(entity);
                    await _unitOfWork.SaveAsync();
                    result.Id = entity.Id;
                    result.UserMessage = CommonMessages.MSG0001;
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }
            return result;
        }

        public Task<ServiceResult<IEnumerable<CaseStatusDTO>>> Find(CaseStatusDTO criteria)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResult<int>> FindCount(CaseStatusDTO criteria)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ServiceResult<IEnumerable<CaseStatusDTO>>> GetAll()
        {
            ServiceResult<IEnumerable<CaseStatusDTO>> result = new ServiceResult<IEnumerable<CaseStatusDTO>>();
            try
            {
                using (_unitOfWork)
                {
                    var list = await _unitOfWork.ClaimStatusRepository.GetAllAsync();
                    result.TransactionResult = list.Select(l => new CaseStatusDTO { ClaimStatus = l.Status.ToString() });
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }

            return result;
        }

        public Task<ServiceResult<CaseStatusDTO>> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResult> RemoveById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResult> Update(CaseStatusDTO model)
        {
            throw new System.NotImplementedException();
        }
    }
}
