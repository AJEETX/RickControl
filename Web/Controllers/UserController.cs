using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using app.Core.Service;
using app.Model.Domain;
using app.Model.Service;
using app.Model.ViewModel.JsonResult;
using app.Model.ViewModel.User;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
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
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IStoreService storeService, IEmployeeService employeeService,
        IRoleService roleService, ICategoryService categoryService, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _userService = userService;
            _storeService = storeService;
            _employeeService = employeeService;
            _roleService = roleService;
            _categoryService = categoryService;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var model = new SearchUserViewModel();
            model.AgencyList = await GetAgencyList();
            model.EmployeeTypeList = await GetEmployeeTypeList() ;
            model.CompanyList = await GetCompanyList();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new CreateUserViewModel();
            model.AgencyList = await GetAgencyList();
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
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    string newFileName = Guid.NewGuid().ToString();
                    string fileExtension = Path.GetExtension(model.ImageFile.FileName);
                    newFileName += fileExtension;
                    var upload = Path.Combine(_webHostEnvironment.WebRootPath, "upload", newFileName);
                    model.ImageFile.CopyTo(new FileStream(upload, FileMode.Create));
                    model.Image = newFileName;
                }

                UserDTO userDTO = new UserDTO{ 
                    Email = model.Email,
                    Password = model.Password,
                    Name = model.Name,
                    Surname = model.Surname,
                    StoreId = model.StoreId,
                    CategoryId = model.CategoryId,
                    EmployeeTypeId = model.EmployeeTypeId,
                    SelectedRoles = model.SelectedUserRoleIds
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
            model.AgencyList = await GetAgencyList();
            model.CompanyList = await GetCompanyList();
            model.EmployeeTypeList = await GetEmployeeTypeList();
            model.UserRoles = await GetUserRoles();
            if (!string.IsNullOrEmpty(model.Image))
                model.ImageDisplayURL = Path.Combine(_webHostEnvironment.WebRootPath, "upload", model.Image);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            JsonResultModel jsonResultModel = new JsonResultModel();
            try
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    string newFileName = Guid.NewGuid().ToString();
                    string fileExtension = Path.GetExtension(model.ImageFile.FileName);
                    newFileName += fileExtension;
                    var upload = Path.Combine(_webHostEnvironment.WebRootPath, "upload", newFileName);
                    model.ImageFile.CopyTo(new FileStream(upload, FileMode.Create));
                    model.Image = newFileName;
                }
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
                        ImageDisplay = l.Image ?? "no-image.png",
                        EmployeeType = l.EmployeeType?.ToString(),
                        CompanyName = l.StoreName,
                        CategoryName = l.CategoryName
                    }).ToList();
                    jsonDataTableModel.aaData = listVM;
                    jsonDataTableModel.iTotalDisplayRecords = listVM.Count;
                    jsonDataTableModel.iTotalRecords = listVM.Count;
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
        private async Task<IEnumerable<SelectListItem>> GetAgencyList()
        {
            ServiceResult<IEnumerable<CategoryDTO>> serviceResult = await _categoryService.GetAll();
            IEnumerable<SelectListItem> drpAgencyList = serviceResult.TransactionResult.Select(s => new SelectListItem { Text = s.CategoryName, Value = s.Id.ToString() });
            return drpAgencyList;
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
