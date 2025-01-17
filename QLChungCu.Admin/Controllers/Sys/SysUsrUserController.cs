﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tour.Admin.Models;
using Tour.Base;
using Tour.Common.Constants;
using Tour.Service;

namespace Tour.Admin.Controllers
{
    public class SysUsrUserController : BaseController
    {
        ISysUsrUserService _sysUsrUserService;
        public SysUsrUserController()
        {
            _sysUsrUserService = new SysUsrUserService(string.Empty);
        }
        public IActionResult Index()
        {
            var vm = new SysUsrUserVM();
            try
            {
                var model = new SysUsrUserFilterModel();
                vm.p = vm.p == 0 ? 1 : vm.p;
                model.pageIndex = vm.p;
                model.pageSize = DefinedConstants.RowPerPage;
                var _listUser = _sysUsrUserService.GetListSysUsrUser(model);
                vm.ListUser = _listUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(vm);
        }
        /// <summary>
        /// _Index
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public PartialViewResult _Index(SysUsrUserVM vm)
        {
            try
            {
                ViewBag.Paging = vm.p;
                var viewModel = vm.ConvertObject<SysUsrUserVM, SysUsrUserFilterModel>();
                viewModel.pageIndex = vm.p == 0 ? 1 : vm.p;
                viewModel.pageSize = DefinedConstants.RowPerPage;
                vm.ListUser = _sysUsrUserService.GetListSysUsrUser(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView(vm);
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: Đăng nhập
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: Đăng nhập
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel viewModel)
        {
            try
            {

                if (viewModel.userName == null && viewModel.password == null)
                {
                    return View(new LoginViewModel()
                    {
                        errorMessage = ResultStatus.UserLoginNull
                    });
                }
                var infoMemer = _sysUsrUserService.LoginSys(
                    new LoginRequestModel()
                    {
                        passWord = viewModel.password,
                        email = viewModel.userName
                    });
                if (infoMemer != null && infoMemer.userID > 0)
                {
                    Constants.UserCde = infoMemer.userCode;
                    Constants.FullName = infoMemer.fullName;
                    Constants.Password = infoMemer.password;
                    Constants.Avatar = infoMemer.avatar == null ? Constants.No_Image : infoMemer.avatar;
                    string strData = infoMemer.ToJSON();
                    HttpContext.Session.SetString(DefinedConstants.SessionUser, strData);
                    return RedirectToAction("Index", "Home", new ChangePassViewModel());
                }
                viewModel.errorMessage = ResultStatus.UserLoginFail;
                return View(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: Phân quyền
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public PartialViewResult _Role(string userCde)
        {
            var vm = new SysUsrRoleViewModel();
            try
            {
                vm.ListSysUsrRole = _sysUsrUserService.GetSysUserRoleByUser(userCde);
                vm.userCde = userCde;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView("_Role", vm);
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: Phân quyền
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult _Role(SysUsrRoleViewModel vm)
        {
            List<SysUserRoleModel> lstModel = new List<SysUserRoleModel>();
            foreach (var item in vm.ListSysUsrRole)
            {
                if (item.isSelected == true)
                {
                    lstModel.Add(new SysUserRoleModel()
                    {
                        createdBy = Constants.UserCde,
                        userCde = vm.userCde,
                        menuCde = item.menuCde,
                        isSelected = item.isSelected
                    });
                }
            }
            var submitResult = _sysUsrUserService.InsertSysUserRoleByUser(lstModel);
            return Json(new
            {
                IsSuccess = submitResult,
                Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
            });
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: tạo mới
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult _Create()
        {
            var vm = new SysUsrUserViewModel();
            vm.avatar = string.IsNullOrWhiteSpace(vm.avatar) ? DefinedConstants.NoImageLink : vm.avatar;
            vm.birthdayView = DateTime.Now;
            return View(vm);
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: tạo mới
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> _Create(SysUsrUserViewModel vm)
        {
            vm.birthday = vm.birthdayView;
            var model = vm.ConvertObject<SysUsrUserViewModel, SysUsrUserModel>();
            try
            {
                string uploads = string.Format("{0}{1}", PathServer.pathDir, PathServer.pathAvatar);
                foreach (var formFile in Request.Form.Files)
                {
                    if (formFile.Length > 0)
                    {
                        var fileName = DateTime.Now.ToString(PathServer.yyyyMMddhhmmssfff);
                        var fileExtension = Path.GetExtension(formFile.FileName);
                        string fileAvatar = fileName + fileExtension;
                        string filePath = Path.Combine(uploads, fileAvatar);
                        if (!Directory.Exists(Path.GetDirectoryName(uploads)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(uploads));
                        }
                        using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await formFile.CopyToAsync(fileStream);
                        }
                        model.avatar = string.Format("{0}{1}{2}", PathServer.pathAvatar, fileAvatar);
                    }
                }
                model.createdBy = Constants.UserCde;
                if (_sysUsrUserService.IsEmailUsed(model))
                {
                    return Json(new
                    {
                        IsSuccess = false,
                        Message = ResultStatus.UserEmailUsed
                    });
                }
                if (!string.IsNullOrWhiteSpace(model.fullName) && !string.IsNullOrWhiteSpace(model.password))
                {
                    var submitResult = _sysUsrUserService.InsertSysUser(model);
                    return Json(new
                    {
                        IsSuccess = submitResult,
                        Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
                    });
                }
                else
                {
                    return Json(new
                    {
                        IsSuccess = false,
                        Message = ResultStatus.FAIL
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = ResultStatus.ERROR
                });
            }
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: cập nhật
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Update(decimal userID)
        {
            var vm = new SysUsrUserViewModel();
            try
            {

                var _lstUser = _sysUsrUserService.GetInfoSysUsrUser(userID);
                vm = _lstUser.ConvertObject<SysUsrUserModel, SysUsrUserViewModel>();

                vm.avatar = string.IsNullOrWhiteSpace(vm.avatar) ? DefinedConstants.NoImageLink : vm.avatar;
                vm.birthdayView = vm.birthday.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(vm);
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> _Update(SysUsrUserViewModel vm)
        {
            vm.birthday = vm.birthdayView;
            var model = vm.ConvertObject<SysUsrUserViewModel, SysUsrUserModel>();
            try
            {
                string uploads = string.Format("{0}{1}", PathServer.pathDir, PathServer.pathAvatar);
                foreach (var formFile in Request.Form.Files)
                {
                    if (formFile.Length > 0)
                    {
                        var fileName = DateTime.Now.ToString(PathServer.yyyyMMddhhmmssfff);
                        var fileExtension = Path.GetExtension(formFile.FileName);
                        string fileAvatar = fileName + fileExtension;
                        string filePath = Path.Combine(uploads, fileAvatar);
                        if (!Directory.Exists(Path.GetDirectoryName(uploads)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(uploads));
                        }
                        using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await formFile.CopyToAsync(fileStream);
                        }
                        model.avatar = string.Format("{0}{1}{2}", PathServer.pathAvatar, fileAvatar);
                    }
                }
                if (_sysUsrUserService.IsEmailUsed(model))
                {
                    return Json(new
                    {
                        IsSuccess = false,
                        Message = ResultStatus.UserEmailUsed
                    });
                }
                if (!string.IsNullOrWhiteSpace(model.fullName) && !string.IsNullOrWhiteSpace(model.password))
                {
                    var submitResult = _sysUsrUserService.InsertSysUser(model);
                    return Json(new
                    {
                        IsSuccess = submitResult,
                        Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
                    });
                }
                else
                {
                    return Json(new
                    {
                        IsSuccess = false,
                        Message = ResultStatus.FAIL
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = ResultStatus.ERROR
                });
            }
        }
        /// <summary>
        ///  Author: dtr
        ///  Description: doi mat khau
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public ActionResult ChangePasswordSysUser(string OldPassword, string Password, string ConfimPassword)
        {
            if (string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(ConfimPassword))
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = ResultStatus.UserPassNull
                });
            }
            if (Password != ConfimPassword)
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = ResultStatus.UserPassNotMatch
                });
            }
            var viewModel = new RequestChangePassModel()
            {
                passWordNew = Password,
                userCde = Constants.UserCde,
                passWordOld = OldPassword
            };
            var result = _sysUsrUserService.ChangePassSysUser(viewModel);
            return Json(new
            {
                IsSuccess = result,
                Message = result ? ResultStatus.SUCCESS : (!result ? ResultStatus.FAIL : ResultStatus.UserOldPass)
            });
        }
        /// <summary>
        /// DeleteSysUsrUser
        /// </summary>
        /// <param name="pUserID"></param>
        /// <param name="pRowVersion"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(decimal pUserID)
        {
            SysUsrUserModel model = new SysUsrUserModel()
            {
                userID = pUserID,
            };
            var submitResult = _sysUsrUserService.DeleteSysUsrUser(model);
            return Json(new
            {
                IsSuccess = submitResult,
                Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
            });
        }
    }
}