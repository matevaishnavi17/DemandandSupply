using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupplyDemandAPI.Models;
using Microsoft.EntityFrameworkCore;



namespace SupplyDemandAPI.Data
{
    public class SupplyDemandDbContext : DbContext
    {
        public SupplyDemandDbContext(DbContextOptions<SupplyDemandDbContext>options):base(options)
        {

        }
        
       public DbSet<Login> login { get; set; }
    }
}