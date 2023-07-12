/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemandAndSupply_FileUpload.Models;

using ExcelDataReader;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace DemandAndSupply_FileUpload.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReadFileApiController : ControllerBase
    {
       

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

        IConfiguration configuration;
        IWebHostEnvironment hostEnvironment;
        DemandAndSupply_Db1Context context;
        IExcelDataReader reader;
        public ReadFileApiController(IConfiguration configuration, IWebHostEnvironment hostEnvironment, DemandAndSupply_Db1Context context)
        {
            this.configuration = configuration;
            this.hostEnvironment = hostEnvironment;
            this.context = context;
        }

        // GET: /<controller>/
        /*public async Task<IActionResult> Index()
        {
            var customerResponseDetails = await context.DemandAndSupplyTbls.ToListAsync();
            return View(customerResponseDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file)
        {
            try
            {
                // Check the File is received

                if (file == null)
                    throw new Exception("File is Not Received...");


                // Create the Directory if it is not exist
                string dirPath = Path.Combine(hostEnvironment.WebRootPath, "ReceivedReports");
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                // MAke sure that only Excel file is used 
                string dataFileName = Path.GetFileName(file.FileName);

                string extension = Path.GetExtension(dataFileName);

                string[] allowedExtsnions = new string[] { ".xls", ".xlsx"};

                if (!allowedExtsnions.Contains(extension))
                    throw new Exception("Sorry! This file is not allowed, make sure that file having extension as either .xls or .xlsx is uploaded.");

                // Make a Copy of the Posted File from the Received HTTP Request
                string saveToPath = Path.Combine(dirPath, dataFileName);

                using (FileStream stream = new FileStream(saveToPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

// USe this to handle Encodeing differences in .NET Core
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                // read the excel file
                using (var stream = new FileStream(saveToPath,FileMode.Open))
                {
                    if (extension == ".xlsx")
                        reader = ExcelReaderFactory.CreateBinaryReader(stream);
                    else
                        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                    DataSet ds = new DataSet();
                    ds = reader.AsDataSet();
                    reader.Close();

                    if (ds != null && ds.Tables.Count > 0)
                    {
                        // Read the the Table
                        DataTable serviceDetails = ds.Tables[0];
                        for (int i = 1; i < serviceDetails.Rows.Count; i++)
                        {
                            DemandAndSupplyTbl details = new DemandAndSupplyTbl();
                            details.SourceInfo = serviceDetails.Rows[i][0].ToString();
                            details.DemandStatus = serviceDetails.Rows[i][1].ToString();
                            details.TeamRequestId = serviceDetails.Rows[i][2].ToString();
                            details.PositionId = serviceDetails.Rows[i][3].ToString();
                            details.RecruitingId = serviceDetails.Rows[i][4].ToString();
                            details.Buaccount = serviceDetails.Rows[i][5].ToString();
                            details.SubSector = serviceDetails.Rows[i][6].ToString();
                            details.MicroSector = serviceDetails.Rows[i][7].ToString();
                            details.Client = serviceDetails.Rows[i][8].ToString();
                            details.DemandType = serviceDetails.Rows[i][9].ToString();
                            details.ProjectCode = serviceDetails.Rows[i][10].ToString();

                            details.JobName = serviceDetails.Rows[i][11].ToString();
                            details.PositionName = serviceDetails.Rows[i][12].ToString();


                            // Add the record in Database
                            await context.DemandAndSupplyTbls.AddAsync(details);
                            await context.SaveChangesAsync();
                        }
                    }
                }
                return Ok(context);
            }
            catch (Exception ex)
            {
               
            }
        }
        
    }
}
*/