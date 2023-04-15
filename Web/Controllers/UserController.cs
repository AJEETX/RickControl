using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Core.Service;
using app.Model.Domain;
using app.Model.Service;
using app.Model.ViewModel.JsonResult;
using app.Model.ViewModel.User;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace app.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IStoreService _storeService;
        private readonly IEmployeeService _employeeService;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IStoreService storeService, IEmployeeService employeeService,
        IRoleService roleService, IMapper mapper)
        {
            _userService = userService;
            _storeService = storeService;
            _employeeService = employeeService;
            _roleService = roleService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var model = new SearchUserViewModel();
            model.EmployeeTypeList = await GetEmployeeTypeList() ;
            model.CompanyList = await GetCompanyList();
            return View(model);
        }

        public async Task<IActionResult> Create()
        {
            var model = new CreateUserViewModel();
            model.EmployeeTypeList = await GetEmployeeTypeList() ;
            model.CompanyList = await GetCompanyList();
            model.UserRoles = await GetUserRoles();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            JsonResultModel jsonResultModel = new JsonResultModel();
            try
            {
                UserDTO userDTO = new UserDTO{ 
                    Email = model.Email,
                    Password = model.Password,
                    Name = model.Surname,
                    Surname = model.Surname,
                    StoreId = model.StoreId,
                    EmployeeTypeId = model.EmployeeTypeId,
                };
                var serviceResult = await _userService.AddAsync(userDTO);
                jsonResultModel = _mapper.Map<JsonResultModel>(serviceResult);
                if (jsonResultModel.IsSucceeded)
                {
                    jsonResultModel.IsRedirect = true;
                    jsonResultModel.RedirectUrl = "/User";
                }
            }
            catch (Exception ex)
            {
                jsonResultModel.IsSucceeded = false;
                jsonResultModel.UserMessage = ex.Message;
            }
            return Json(jsonResultModel);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var serviceResult = await _userService.GetById(id);
            EditUserViewModel model = _mapper.Map<EditUserViewModel>(serviceResult.TransactionResult);
            model.CompanyList = await GetCompanyList();
            model.EmployeeTypeList = await GetEmployeeTypeList();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            JsonResultModel jsonResultModel = new JsonResultModel();
            try
            {
                UserDTO userDTO = _mapper.Map<UserDTO>(model);
                var serviceResult = await _userService.Update(userDTO);
                jsonResultModel = _mapper.Map<JsonResultModel>(serviceResult);
                if (jsonResultModel.IsSucceeded)
                {
                    jsonResultModel.IsRedirect = true;
                    jsonResultModel.RedirectUrl = "/User";
                }
            }
            catch (Exception ex)
            {
                jsonResultModel.IsSucceeded = false;
                jsonResultModel.UserMessage = ex.Message;
            }
            return Json(jsonResultModel);
        }


        [HttpGet]
        public async Task<IActionResult> List(SearchUserViewModel model)
        {
            JsonDataTableModel jsonDataTableModel = new JsonDataTableModel();
            try
            {
                UserDTO userDTO = _mapper.Map<UserDTO>(model);
                ServiceResult<int> serviceCountResult = await _userService.FindCount(userDTO);
                ServiceResult<IEnumerable<UserDTO>> serviceListResult = await _userService.Find(userDTO);

                if (serviceCountResult.IsSucceeded && serviceListResult.IsSucceeded)
                {
                    List<ListUserViewModel> listVM = serviceListResult.TransactionResult.Select(l => new ListUserViewModel{
                        Id =(int) l.Id,
                        Email = l.Email,
                        Name = l.Name,
                        Surname = l.Surname,
                        EmployeeType = l.EmployeeType?.ToString(),
                        CompanyName = l.StoreName
                    }).ToList();
                    jsonDataTableModel.aaData = listVM;
                    jsonDataTableModel.iTotalDisplayRecords = serviceCountResult.TransactionResult;
                    jsonDataTableModel.iTotalRecords = serviceCountResult.TransactionResult;
                }
                else
                {
                    jsonDataTableModel.IsSucceeded = false;
                    jsonDataTableModel.UserMessage = serviceCountResult.UserMessage + "-" + serviceListResult.UserMessage;
                }
            }
            catch (Exception ex)
            {
                jsonDataTableModel.IsSucceeded = false;
                jsonDataTableModel.UserMessage = ex.Message;
            }

            return Json(jsonDataTableModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            JsonResultModel jsonResultModel = new JsonResultModel();
            try
            {
                ServiceResult serviceResult = await _userService.RemoveById(id);
                jsonResultModel = _mapper.Map<JsonResultModel>(serviceResult);
            }
            catch (Exception ex)
            {
                jsonResultModel.IsSucceeded = false;
                jsonResultModel.UserMessage = ex.Message;
            }
            return Json(jsonResultModel);
        }
        private async Task<IEnumerable<SelectListItem>> GetUserRoles()
        {
            var serviceResult = await _roleService.GetAll();
            var result = serviceResult.TransactionResult.Select(s => new SelectListItem{
                Value = s.RoleCode,
                Text = s.RoleName
            });
            return result;
        }
        private async Task<IEnumerable<SelectListItem>> GetCompanyList()
        {
            ServiceResult<IEnumerable<StoreDTO>> serviceResult = await _storeService.GetAll();
            IEnumerable<SelectListItem> drpCompanyList = serviceResult.TransactionResult.Select(s => new SelectListItem { Text = s.StoreName, Value = s.Id.ToString() });
            return drpCompanyList;
        }

        private async Task<IEnumerable<SelectListItem>> GetEmployeeTypeList()
        {
            ServiceResult<IEnumerable<EmployeeTypeDTO>> serviceResult = await _employeeService.GetAll();
            IEnumerable<SelectListItem> drpEmployeeTypeList = serviceResult.TransactionResult.Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() });
            return drpEmployeeTypeList;
        }        
    }
}
