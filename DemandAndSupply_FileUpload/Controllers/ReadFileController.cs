using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
//using DemandAndSupply_FileUpload.Models;
using ExcelDataReader;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Net;

namespace DemandAndSupply_FileUpload.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReadFileController : ControllerBase
    {
        
 
        /*[Route("ReadFile")]
        [HttpPost]
        public async Task<IActionResult> ReadExcelFile(List<IFormFile> formFiles)
        {
            try
            {
                #region Variable Declaration
                string message = "";
                HttpResponseMessage ResponseMessage = null;
                var httpRequest = HttpContext.Connection.RequestClose;
                DataSet dsexcelRecords = new DataSet();
                IExcelDataReader reader = null;
                IFormFile Inputfile = null;
                formFiles=null;
                Stream FileStream = null;
                #endregion
 
                #region Save Student Detail From Excel
                using (DemandAndSupply_Db1Context objEntity = new DemandAndSupply_Db1Context())
                {
                    /*if (httpRequest.CountdownEvent > 0)
                    {
                        Inputfile = httpRequest.Files[0];
                        FileStream = Inputfile.InputStream;

                        Inputfile=httpRequest
 
                        if (Inputfile != null && FileStream != null)
                        {
                            if (Inputfile.FileName.EndsWith(".xls"))
                                reader = ExcelReaderFactory.CreateBinaryReader(FileStream);
                            else if (Inputfile.FileName.EndsWith(".xlsx"))
                                reader = ExcelReaderFactory.CreateOpenXmlReader(FileStream);
                            else
                                message = "The file format is not supported.";
 
                            dsexcelRecords = reader.AsDataSet();
                            reader.Close();
 
                            if (dsexcelRecords != null && dsexcelRecords.Tables.Count > 0)
                            {
                                DataTable dtStudentRecords = dsexcelRecords.Tables[0];
                                for (int i = 0; i < dtStudentRecords.Rows.Count; i++)
                                {
                                    DemandAndSupplyTbl objStudent = new DemandAndSupplyTbl();
                                    objStudent.SourceInfo = Convert.ToString(dtStudentRecords.Rows[i][0]);
                                    objStudent. = Convert.ToString(dtStudentRecords.Rows[i][1]);
                                    objStudent.Name = Convert.ToString(dtStudentRecords.Rows[i][2]);
                                    objStudent.Branch = Convert.ToString(dtStudentRecords.Rows[i][3]);
                                    objStudent.University = Convert.ToString(dtStudentRecords.Rows[i][4]);
                                    objEntity.Students.Add(objStudent);
                                }
 
                                int output = objEntity.SaveChanges();
                                if (output > 0)
                                    message = "The Excel file has been successfully uploaded.";
                                else
                                    message = "Something Went Wrong!, The Excel file uploaded has fiald.";
                            }
                            else
                                message = "Selected file is empty.";
                        }
                        else
                            message = "Invalid File.";
                    }
                    else
                        ResponseMessage = Request.CreateResponse(HttpStatusCode.BadRequest);
                }
                return Ok(message);
                #endregion
            }
            catch (Exception)
            {
                throw;
            }
        }*/
    }
}
