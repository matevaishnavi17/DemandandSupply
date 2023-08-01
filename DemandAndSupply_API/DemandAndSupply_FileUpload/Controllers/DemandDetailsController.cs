using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemandAndSupply_FileUpload.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemandAndSupply_FileUpload.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemandDetailsController : ControllerBase
    {
        private readonly DemandAndSupply_Db1Context _context;
        public DemandDetailsController(DemandAndSupply_Db1Context context )
        {
            _context = context;
            
        }

        [HttpGet ("GetAll")]
               
        public async Task<IActionResult> GetAll()
        {
            var demand = await  _context.DemandSupplyTbl3s.ToListAsync();
            return Ok(demand);
        }

        [HttpGet ("GetByPositionId/{id}")]
        public async Task<ActionResult<IEnumerable<DemandSupplyTbl3>>> GetByPositionId( string id)
        {
            var demand = await _context.DemandSupplyTbl3s.FirstOrDefaultAsync( x =>x.PositionId == id);
            return Ok(demand);     
        }
    }
}