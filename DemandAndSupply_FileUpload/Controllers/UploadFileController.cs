using System;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DemandAndSupply_FileUpload.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace DemandAndSupply_FileUpload.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadFileController : ControllerBase
    {

    private readonly DemandAndSupply_Db1Context _dbContext;

    public UploadFileController(DemandAndSupply_Db1Context dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadExcel(IFormFile file)
    {
        
        if (file == null || file.Length == 0)
        {
            return BadRequest("Please select a file to upload.");
        }

         // Validate file size
        const long maxSize = 20 * 1024 * 1024; // 10MB
        if (file.Length > maxSize)
        {
            return BadRequest("File size exceeds the maximum limit of 20MB.");
        }

        // Validate file type
        string[] allowedType = { "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",// XLSX
        "application/vnd.ms-excel",//xls
        "text/csv",//csv
        "application/vnd.ms-excel.sheet.binary.macroenabled.12" //xlsb
        };

    
        if (!allowedType.Contains(file.ContentType))
        {
            return BadRequest("Invalid file type. Only xls, xlsx, and xlsb files are allowed.");
        }

        //DateTime dateTime;
        using (var package = new ExcelPackage(file.OpenReadStream()))
        {
            var worksheet = package.Workbook.Worksheets[0];
            var rowCount = worksheet.Dimension.Rows;

            List<DemandSupplyTbl3> demandData = new List<DemandSupplyTbl3>();
            for (int row = 2; row <= rowCount; row++) // Assuming the first row contains headers
            {
                demandData.Add(new DemandSupplyTbl3
                {
                    
                    SourceInfo = worksheet.Cells[row, 1].Value?.ToString(),
                    DemandStatus = worksheet.Cells[row, 2].Value?.ToString(),
                    TeamRequestId = worksheet.Cells[row, 3].Value?.ToString(),
                    PositionId = worksheet.Cells[row, 4].Value?.ToString(),
                    RecruitingId = worksheet.Cells[row, 5].Value?.ToString(),
                    Buaccount = worksheet.Cells[row, 6].Value?.ToString(),
                    SubSector = worksheet.Cells[row, 7].Value?.ToString(),
                    MicroSector = worksheet.Cells[row, 8].Value?.ToString(),
                    Client = worksheet.Cells[row, 9].Value?.ToString(),
                    DemandType = worksheet.Cells[row, 10].Value?.ToString(),
                    ProjectCode = worksheet.Cells[row, 11].Value?.ToString(),
                    JobName = worksheet.Cells[row, 12].Value?.ToString(),
                    PositionName = worksheet.Cells[row, 13].Value?.ToString(),
                    TeamRequestName = worksheet.Cells[row, 14].Value?.ToString(),
                    LocalGrade = worksheet.Cells[row, 15].Value?.ToString(),
                    GlobalGrade = worksheet.Cells[row, 16].Value?.ToString(),
                    RoleNotes = worksheet.Cells[row, 17].Value?.ToString(),
                    RoleType = worksheet.Cells[row, 18].Value?.ToString(),
                    BackFillReason = worksheet.Cells[row, 19].Value?.ToString(),
                    OutgoingEmployee = worksheet.Cells[row, 20].Value?.ToString(),
                    //RoleEndDate=DateTime.TryParseExact(worksheet.Cells[row, 21].Value,"yyyyMMdd",CultureInfo.InvariantCulture,System.Globalization.DateTimeStyles.None,out dateTime),
                    //RoleStartDate = Convert.ToDateTime(worksheet.Cells[row, 21].Value),
                    //RoleEndDate = Convert.ToDateTime(worksheet.Cells[row, 22].Value),
                     RoleStartDate = worksheet.Cells[row, 21].Value?.ToString(),
                     RoleEndDate = worksheet.Cells[row, 22].Value?.ToString(),
                    FulfillmentChannelFinal = worksheet.Cells[row, 23].Value?.ToString(),
                    DemandFulfillmentStatus = worksheet.Cells[row, 24].Value?.ToString(),
                    AdditionalNotes = worksheet.Cells[row, 25].Value?.ToString(),
                    Buskills = worksheet.Cells[row, 26].Value?.ToString(),
                    Practice = worksheet.Cells[row, 27].Value?.ToString(),
                    GlobalPractice = worksheet.Cells[row, 28].Value?.ToString(),
                    Fte = worksheet.Cells[row, 29].Value?.ToString(),
                    CountryOfDelivery = worksheet.Cells[row, 30].Value?.ToString(),
                    //CreationDate = Convert.ToDateTime(worksheet.Cells[row, 31].Value),
                    CreationDate = worksheet.Cells[row, 31].Value?.ToString(),
                    //UpdatedOn = Convert.ToDateTime(worksheet.Cells[row, 32].Value),
                    UpdatedOn = worksheet.Cells[row, 32].Value?.ToString(),
                    WeekByStatus = worksheet.Cells[row, 33].Value?.ToString(),
                    LeadtimeInDays = worksheet.Cells[row, 34].Value?.ToString(),
                    Ageing =worksheet.Cells[row, 35].Value?.ToString(),
                    RequestUpdater = worksheet.Cells[row, 36].Value?.ToString(),
                    TeamRequestComment = worksheet.Cells[row, 37].Value?.ToString(),
                    Busphandler = worksheet.Cells[row, 38].Value?.ToString(),
                    Psphandler = worksheet.Cells[row, 39].Value?.ToString(),
                    Recruiter = worksheet.Cells[row, 40].Value?.ToString(),
                    DeliveryRole = worksheet.Cells[row, 41].Value?.ToString(),
                    DeliverySkills = worksheet.Cells[row, 42].Value?.ToString(),
                    RequestedBy = worksheet.Cells[row, 43].Value?.ToString(),
                    ClientReference = worksheet.Cells[row, 44].Value?.ToString(),
                    ExpectedDailyRate = worksheet.Cells[row, 45].Value?.ToString(),
                    RoleComment = worksheet.Cells[row, 46].Value?.ToString(),
                    DeliveryType = worksheet.Cells[row, 47].Value?.ToString(),
                    PrimaryLocationName = worksheet.Cells[row, 48].Value?.ToString(),
                    LocationDescription = worksheet.Cells[row, 49].Value?.ToString(),
                    PrimaryCity = worksheet.Cells[row, 50].Value?.ToString(),
                    PrimaryState = worksheet.Cells[row, 51].Value?.ToString(),
                    PrimaryZipCode = worksheet.Cells[row, 52].Value?.ToString(),
                    PrimaryRegion = worksheet.Cells[row, 53].Value?.ToString(),
                    PrimaryGeoName = worksheet.Cells[row, 54].Value?.ToString(),
                    PrimaryGeoCity = worksheet.Cells[row, 55].Value?.ToString(),
                    ClosestGeoHub = worksheet.Cells[row, 56].Value?.ToString(),
                    Hub = worksheet.Cells[row, 57].Value?.ToString(),
                    ProductionUnit = worksheet.Cells[row, 58].Value?.ToString(),
                    ProductionUnitName = worksheet.Cells[row, 59].Value?.ToString(),
                    TargetBillRate = worksheet.Cells[row, 60].Value?.ToString(),
                    SellingBu = worksheet.Cells[row, 61].Value?.ToString(),
                    RequisitionLocation = worksheet.Cells[row, 62].Value?.ToString(),
                    DemandGeo = worksheet.Cells[row, 63].Value?.ToString(),
                    ClientLocation = worksheet.Cells[row, 64].Value?.ToString(),
                    AccountRegion = worksheet.Cells[row, 65].Value?.ToString(),
                    AccountGeoName = worksheet.Cells[row, 66].Value?.ToString(),
                    AccountGeoCity = worksheet.Cells[row, 67].Value?.ToString(),
                    ThorStage = worksheet.Cells[row, 68].Value?.ToString(),
                    HeadCountType = worksheet.Cells[row, 69].Value?.ToString(),
                    S2rmanaged = worksheet.Cells[row, 70].Value?.ToString(),
                    DmdcaseStatus = worksheet.Cells[row, 71].Value?.ToString(),
                    TaskLabel = worksheet.Cells[row, 72].Value?.ToString(),
                    S2rid = worksheet.Cells[row, 73].Value?.ToString(),
                    S2rcaseId = worksheet.Cells[row, 74].Value?.ToString(),
                    CandidateCount = worksheet.Cells[row, 75].Value?.ToString(),
                    AssignedTo = worksheet.Cells[row, 76].Value?.ToString(),
                    TeamRequestStatus = worksheet.Cells[row, 77].Value?.ToString(),
                    ThorOptyId = worksheet.Cells[row, 78].Value?.ToString(),
                    ThorContractType = worksheet.Cells[row, 79].Value?.ToString(),
                    //ThorCloseDate = Convert.ToDateTime(worksheet.Cells[row, 80].Value?),
                    //ThorCloseDate= DateTime.FromOADate((double)worksheet.Cells[row, 80].Value?),
                    //ThorCloseDate= Convert.ToDateTime(worksheet.Cells[row,80].Value),
                    //ThorStartDate = Convert.ToDateTime(worksheet.Cells[row, 81].Value), 
                    
                    ThorCloseDate= worksheet.Cells[row,80].Value?.ToString(),
                    ThorStartDate = worksheet.Cells[row, 81].Value?.ToString(),
                    MarketUnitBu = worksheet.Cells[row, 82].Value?.ToString(),
                    RequestCreator = worksheet.Cells[row, 83].Value?.ToString(),
                    LeadMarketArea = worksheet.Cells[row, 84].Value?.ToString(),
                    LeadPracticeArea = worksheet.Cells[row, 85].Value?.ToString(),
                    SourceOfDemand=worksheet.Cells[row,87].Value?.ToString(),
                    AgedPastDue = worksheet.Cells[row, 86].Value?.ToString(),
                    WeekByStatusGrouped=worksheet.Cells[row,87].Value?.ToString(),
                    DurationInAgedPastStatus=worksheet.Cells[row,88].Value?.ToString(),
                    DaysSincePastDue=worksheet.Cells[row,89].Value?.ToString(),
                    SelfAppliedApplications = worksheet.Cells[row, 90].Value?.ToString(),
                    Visible = worksheet.Cells[row, 91].Value?.ToString(),
                    IsClientInterviewRequired = worksheet.Cells[row, 92].Value?.ToString(),
                    ExcludeOffshore = worksheet.Cells[row, 93].Value?.ToString(),
                    LeadMarketAndPractice = worksheet.Cells[row, 94].Value?.ToString(),
                    ForecastType = worksheet.Cells[row, 95].Value?.ToString(),
                }
                );
            }

            // Store data into the database
                 await _dbContext.DemandSupplyTbl3s.AddRangeAsync(demandData);
                 await _dbContext.SaveChangesAsync();
                return Ok("success");
        }
    }
}   
    }