using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using app.Core.Service;
using app.Model.Domain;
using app.Model.Service;
using app.Model.ViewModel.Role;
using app.Model.ViewModel.JsonResult;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace app.Web.Controllers
{
    public class RoleController : Controller
    {
        
        private readonly IMapper _mapper;
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService, IMapper mapper)
        {
            _mapper = mapper;
            _roleService = roleService;
        }
       public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Create(CreateRoleViewModel model)
        {
            JsonResultModel jsonResultModel = new JsonResultModel();
            try
            {
                RoleDTO roleDTO = new RoleDTO {RoleCode = model.RoleCode, RoleName = model.RoleName};
                var serviceResult = await _roleService.AddAsync(roleDTO);
                jsonResultModel = _mapper.Map<JsonResultModel>(serviceResult);
                if (jsonResultModel.IsSucceeded)
                {
                    jsonResultModel.IsRedirect = true;
                    jsonResultModel.RedirectUrl = "/Role";
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
            var serviceResult = await _roleService.GetById(id);
            EditRoleViewModel model = new EditRoleViewModel { 
                RoleCode =  serviceResult.TransactionResult.RoleCode, 
                RoleName = serviceResult.TransactionResult.RoleName};
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Edit(EditRoleViewModel model)
        {
            JsonResultModel jsonResultModel = new JsonResultModel();
            try
            {
                RoleDTO roleDTO = new RoleDTO { RoleCode = model.RoleCode, RoleName = model.RoleName};
                var serviceResult = await _roleService.Update(roleDTO);
                jsonResultModel = _mapper.Map<JsonResultModel>(serviceResult);
                if (jsonResultModel.IsSucceeded)
                {
                    jsonResultModel.IsRedirect = true;
                    jsonResultModel.RedirectUrl = "/Role";
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
        public async Task<IActionResult> List(SearchRoleViewModel model)
        {
            JsonDataTableModel jsonDataTableModel = new JsonDataTableModel();
            try
            {
                RoleDTO roleDTO = new RoleDTO { RoleCode = model.RoleCode, RoleName = model.RoleName};
                ServiceResult<int> serviceCountResult = await _roleService.FindCount(roleDTO);
                ServiceResult<IEnumerable<RoleDTO>> serviceListResult = await _roleService.Find(roleDTO);

                if (serviceCountResult.IsSucceeded && serviceListResult.IsSucceeded)
                {
                    List<ListRoleViewModel> listVM = serviceListResult.TransactionResult.Select(s => new ListRoleViewModel{
                        Id = s.Id.Value,
                        RoleName = s.RoleName,
                        RoleCode = s.RoleCode
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
                ServiceResult serviceResult = await _roleService.RemoveById(id);
                jsonResultModel = _mapper.Map<JsonResultModel>(serviceResult);
            }
            catch (Exception ex)
            {
                jsonResultModel.IsSucceeded = false;
                jsonResultModel.UserMessage = ex.Message;
            }
            return Json(jsonResultModel);
        }             
    }
}
