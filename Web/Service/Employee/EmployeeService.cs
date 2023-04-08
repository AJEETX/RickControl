
using app.Core;
using app.Core.Service;
using app.Data.Entity;
using app.Message;
using app.Model.Domain;
using app.Model.Service;
using app.Service.Base;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Service.Employee
{
    public class EmployeeService : BaseService, IEmployeeService
    {
        public EmployeeService(IUnitOfWorks unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public Task<ServiceResult> AddAsync(EmployeeTypeDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult<IEnumerable<EmployeeTypeDTO>>> Find(EmployeeTypeDTO criteria)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult<int>> FindCount(EmployeeTypeDTO criteria)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResult<IEnumerable<EmployeeTypeDTO>>> GetAll()
        {
              ServiceResult<IEnumerable<EmployeeTypeDTO>> result = new ServiceResult<IEnumerable<EmployeeTypeDTO>>();
            try
            {
                using (_unitOfWork)
                {
                    IEnumerable<EmployeeType> list = await _unitOfWork.EmployeeRepository.GetAllAsync();
                    result.TransactionResult = _mapper.Map<IEnumerable<EmployeeTypeDTO>>(list);
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }

            return result;
        }

        public Task<ServiceResult<EmployeeTypeDTO>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult> RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult> Update(EmployeeTypeDTO model)
        {
            throw new NotImplementedException();
        }
    }
}