using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using DemandAndSupply_FileUpload.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DemandAndSupply_FileUpload.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReadExcelFileController : ControllerBase
    {
        /*public DemandAndSupply_Db1Context _dbContext;

        public ReadExcelFileController(DemandAndSupply_Db1Context dbContext){
            _dbContext=dbContext;
        }
        [HttpPost]
        public async Task<IActionResult> ReadExcel(IFormFile formFile)
        {
            string storedProc = string.Empty;
            storedProc= "ImportExcelFile";

        var connection = (SqlConnection)_dbContext.Database.AsSqlServer().Connection.DbConnection;

        var command = connection.CreateCommand();
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "MySproc";
        command.Parameters.AddWithValue("@MyParameter", 42);

command.ExecuteNonQuery();
            
        using (var connection = new SqlConnection("DbConn"))
        {
            using (var command = new SqlCommand(storedProc, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SheetName","NA BU Daily Open Demand Report-1 - 1");
                command.Parameters.AddWithValue("@FilePath",formFile);
                command.Parameters.AddWithValue("@HRD","Yes");
                command.Parameters.AddWithValue("@TableName","MasterTable");
                connection.Open();
                command.ExecuteNonQuery();
                return Ok("Success");
            }
        }
    }*/
}
}