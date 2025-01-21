
using BusinessObjectsLayer.Entities;
using Converge.Shared.Helper;
using Dapper;
using DataAccess.DbContext;
using DataAccessLayer.Interface;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ErrorLog;
using Microsoft.AspNetCore.Http;
using System.Data;
using static Converge.Shared.Helper.EnumHelper;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;
        private readonly HttpContextAccessor _httpContextAccessor;
        public UserRepository(HttpContextAccessor httpContextAccessor,DapperContext context)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
      

        public async Task<dynamic> GetCustomer(int PageNumber, int PageSize)
        { 
            try
            {
                using (var connection = _context.CreateConnection())
                {
                    var parameters = new
                    {
                        PageNumber= PageNumber,
                        PageSize = PageSize,
                    };
                 return   (await connection.QueryAsync("GetCustomer", parameters, commandType: CommandType.StoredProcedure)).ToList();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}
