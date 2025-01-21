using BusinessLogicLayer.Interfaces;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DataAccessLayer.Interface;
using BusinessObjectsLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using DocumentFormat.OpenXml.Spreadsheet;
using DataAccessLayer.Repositories;
using DocumentFormat.OpenXml.Math;
using ErrorLog;
using static Converge.Shared.Helper.EnumHelper;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Text.Json.Nodes;

namespace BusinessLogicLayer.Service
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository; 

        public UserService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository; 
        }
        
     public async Task<dynamic> GetCustomer(int PageNumber, int PageSize)
        {
            try
            {
                var res = await _userRepository.GetCustomer(PageNumber, PageSize);
                return res;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
