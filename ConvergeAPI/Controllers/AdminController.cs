using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Response;
using BusinessLogicLayer.Service;
using BusinessObjectsLayer.Entities;
using Converge.Shared.Helper;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using ErrorLog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConvergeAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController] 
    public class AdminController : ControllerBase
    {
        #region Depedenices
        private readonly IConfiguration _configuration; 
        private readonly IWebHostEnvironment _environment; 
        private static IHttpContextAccessor? _httpContextAccessor;
        private readonly IUserService _userService;
        #endregion


        #region Constructor

        public AdminController(IConfiguration configuration, IHttpContextAccessor httpContextAccessor, 
             IWebHostEnvironment environment, IUserService userService)
        { 
            _environment = environment; 
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _configuration = configuration;
        }

        #endregion

        #region Customers

        [HttpGet("GetCustomer")]
        public async Task<IActionResult> GetCustomer(int PageNumber, int PageSize)
        {
            try
            {
                return Ok(ResponseHelper.GetSuccessResponse(await _userService.GetCustomer(PageNumber, PageSize)));
            }
            catch (Exception ex)
            { 
                return Ok(ResponseHelper.GetFailureResponse());
            }
        }
        #endregion 
    }
}
