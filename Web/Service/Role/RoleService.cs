using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using app.Message;
using Entity = app.Data.Entity;
using app.Service.Base;
using app.Core.Service;
using app.Model.Service;
using app.Model.Domain;
using app.Core;
using System.Linq;

namespace app.Service.Role
{
    public class RoleService: BaseService, IRoleService
    {
        public RoleService(IUnitOfWorks unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<ServiceResult> AddAsync(RoleDTO model)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                using (_unitOfWork)
                {
                    var entity = new Entity.Role { Name = model.RoleName, Code = model.RoleCode};
                    entity.CreateDate = DateTime.Now;
                    await _unitOfWork.RoleRepository.AddAsync(entity);
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

        public async Task<ServiceResult<IEnumerable<RoleDTO>>> Find(RoleDTO criteria)
        {
            var result = new ServiceResult<IEnumerable<RoleDTO>>();

            try
            {
                using (_unitOfWork)
                {
                    IEnumerable<Entity.Role> list = await _unitOfWork
                                                                .RoleRepository
                                                                .FindAsync(filter: x => 
                                                                (
                                                                    string.IsNullOrEmpty(criteria.RoleName) || x.Name.Contains(criteria.RoleName) &&
                                                                    string.IsNullOrEmpty(criteria.RoleCode) || x.Code.Contains(criteria.RoleCode)

                                                                ),
                                                                           orderByDesc: x => x.Id,
                                                                           skip: criteria.PageNumber,
                                                                           take: criteria.RecordCount);

                    result.TransactionResult = list.Select(l => new RoleDTO{Id = l.Id, RoleName = l.Name, RoleCode = l.Code });
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }

            return result;
        }

        public async Task<ServiceResult<int>> FindCount(RoleDTO criteria)
        {
            ServiceResult<int> result = new ServiceResult<int>();

            try
            {
                using (_unitOfWork)
                {
                    int count = await _unitOfWork.RoleRepository.FindCountAsync(filter: x => 
                    (string.IsNullOrEmpty(criteria.RoleName) || x.Name.Contains(criteria.RoleName)) && 
                    (string.IsNullOrEmpty(criteria.RoleCode) || x.Code.Contains(criteria.RoleCode)) 
                    );
                    result.TransactionResult = count;
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }

            return result;
        }

        public async Task<ServiceResult<IEnumerable<RoleDTO>>> GetAll()
        {
            ServiceResult<IEnumerable<RoleDTO>> result = new ServiceResult<IEnumerable<RoleDTO>>();
            try
            {
                using (_unitOfWork)
                {
                    IEnumerable<Entity.Role> list = await _unitOfWork.RoleRepository.GetAllAsync();
                    result.TransactionResult = list.Select(l => new RoleDTO{RoleName = l.Name, RoleCode = l.Code });
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }

            return result;
        }

        public async Task<ServiceResult<RoleDTO>> GetById(int id)
        {
            ServiceResult<RoleDTO> result = new ServiceResult<RoleDTO>();
            try
            {
                using (_unitOfWork)
                {
                    Entity.Role entity = await _unitOfWork.RoleRepository.GetByIdAsync(id);
                    result.TransactionResult = new RoleDTO{ RoleName = entity.Name, RoleCode = entity.Code };
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }
            return result;
        }

        public async Task<ServiceResult> RemoveById(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                using (_unitOfWork)
                {
                    await _unitOfWork.RoleRepository.RemoveById(id);
                    await _unitOfWork.SaveAsync();
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

        public async Task<ServiceResult> Update(RoleDTO model)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                using (_unitOfWork)
                {
                    Entity.Role entity = await _unitOfWork.RoleRepository.GetByIdAsync(model.Id.Value);
                    if (entity != null)
                    {
                       entity.Name = model.RoleName;
                       entity.Code = model.RoleCode;
                        _unitOfWork.RoleRepository.Update(entity);
                        await _unitOfWork.SaveAsync();
                        result.UserMessage = CommonMessages.MSG0001;
                    }
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }
            return result;
        }
    }
}