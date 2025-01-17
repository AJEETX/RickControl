﻿using AutoMapper;
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
using app.Common.Extensions;
using System.Linq;

namespace app.Service.User
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IUnitOfWorks unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<ServiceResult> AddAsync(UserDTO model)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                using (_unitOfWork)
                {
                    bool emailValidation = await _unitOfWork.UserRepository.EmailValidationCreateUser(model.Email);

                    if (!emailValidation)
                    {
                        Entity.User entity = _mapper.Map<Data.Entity.User>(model);
                        entity.Password = model.Password.MD5Hash();
                        entity.CreateDate = DateTime.Now;
                        entity.EmployeeTypeId = model.EmployeeTypeId;
                        entity.StoreId = model.StoreId;

                        await _unitOfWork.UserRepository.AddAsync(entity);
                        await _unitOfWork.SaveAsync();
                        result.Id = entity.Id;
                        result.UserMessage = CommonMessages.MSG0001;
                    }
                    else
                    {
                        result.IsSucceeded = false;
                        result.UserMessage = CommonMessages.MSG0003;
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
        public async Task<ServiceResult<IEnumerable<UserDTO>>> Find(UserDTO criteria)
        {
            ServiceResult<IEnumerable<UserDTO>> result = new ServiceResult<IEnumerable<UserDTO>>();
            try
            {
                using (_unitOfWork)
                {
                    IEnumerable<Entity.User> list = await _unitOfWork
                                                                .UserRepository
                                                                .FindAsync(filter: x => (string.IsNullOrEmpty(criteria.Email) || x.Email.Contains(criteria.Email)) &&
                                                                                        (criteria.StoreId == 0 || x.StoreId == criteria.StoreId) &&
                                                                                        (criteria.EmployeeTypeId == null || x.EmployeeTypeId == criteria.EmployeeTypeId) &&
                                                                                        (string.IsNullOrEmpty(criteria.Name) || x.Name.Contains(criteria.Name)) &&
                                                                                        (string.IsNullOrEmpty(criteria.Surname) || x.Surname.Contains(criteria.Surname)),
                                                                           includes: new List<string>() { "Store", "EmployeeType" },
                                                                           orderByDesc: x => x.Id,
                                                                           skip: criteria.PageNumber,
                                                                           take: criteria.RecordCount);

                    result.TransactionResult = list.Select(l => new UserDTO{
                        Id = l.Id,
                        Email = l.Email,
                        Password = l.Password,
                        Name = l.Surname,
                        Surname = l.Surname,
                        StoreName = l.Store?.StoreName,
                        EmployeeType = l.EmployeeType.Name,
                    });
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }
            return result;
        }
        public async Task<ServiceResult<int>> FindCount(UserDTO criteria)
        {
            ServiceResult<int> result = new ServiceResult<int>();
            try
            {
                using (_unitOfWork)
                {
                    int count = await _unitOfWork.UserRepository
                                                  .FindCountAsync(filter: x => (string.IsNullOrEmpty(criteria.Email) || x.Email.Contains(criteria.Email)) &&
                                                                               (criteria.StoreId == 0 || x.StoreId == criteria.StoreId) &&
                                                                               (criteria.EmployeeTypeId == null || x.EmployeeTypeId == criteria.EmployeeTypeId) &&
                                                                               (string.IsNullOrEmpty(criteria.Name) || x.Name.Contains(criteria.Name)) &&
                                                                               (string.IsNullOrEmpty(criteria.Surname) || x.Surname.Contains(criteria.Surname)));

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
        public async Task<ServiceResult<IEnumerable<UserDTO>>> GetAll()
        {
            ServiceResult<IEnumerable<UserDTO>> result = new ServiceResult<IEnumerable<UserDTO>>();
            try
            {
                using (_unitOfWork)
                {
                    IEnumerable<Entity.User> list = await _unitOfWork.UserRepository.GetAllAsync();
                    result.TransactionResult = _mapper.Map<IEnumerable<UserDTO>>(list);
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }

            return result;
        }
        public async Task<ServiceResult<UserDTO>> GetById(int id)
        {
            ServiceResult<UserDTO> result = new ServiceResult<UserDTO>();
            try
            {
                using (_unitOfWork)
                {
                    Entity.User entity = await _unitOfWork.UserRepository.GetByIdAsync(id);
                    result.TransactionResult = _mapper.Map<UserDTO>(entity);
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.UserMessage = string.Format(CommonMessages.MSG0002, ex.Message);
            }
            return result;
        }
        public async Task<ServiceResult> Login(string email, string password)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                using (_unitOfWork)
                {
                    bool login = await _unitOfWork.UserRepository.Login(email, password.MD5Hash());
                    if (login)
                        result.IsSucceeded = true;
                    else
                    {
                        result.IsSucceeded = false;
                        result.UserMessage = CommonMessages.MSG0005;
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
        public async Task<ServiceResult> RemoveById(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                using (_unitOfWork)
                {
                    await _unitOfWork.UserRepository.RemoveById(id);
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
        public async Task<ServiceResult> Update(UserDTO model)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                using (_unitOfWork)
                {
                    Entity.User entity = await _unitOfWork.UserRepository.GetByIdAsync(model.Id.Value);
                    if (entity != null)
                    {
                        bool emailValidation = await _unitOfWork.UserRepository.EmailValidationUpdateUser(model.Email, model.Id.Value);

                        if (!emailValidation)
                        {

                            string oldPassword = entity.Password;
                            if (!string.IsNullOrEmpty(model.Password))
                                model.Password = model.Password.MD5Hash();
                            else
                                model.Password = oldPassword;

                            _mapper.Map(model, entity);
                            _unitOfWork.UserRepository.Update(entity);

                            await _unitOfWork.SaveAsync();
                            result.UserMessage = CommonMessages.MSG0001;
                        }
                        else
                        {
                            result.IsSucceeded = false;
                            result.UserMessage = CommonMessages.MSG0003;
                        }
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
