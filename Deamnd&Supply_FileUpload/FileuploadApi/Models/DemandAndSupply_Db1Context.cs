using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FileuploadApi.Models
{
    public partial class DemandAndSupply_Db1Context : DbContext
    {
        public DemandAndSupply_Db1Context()
        {
        }

        public DemandAndSupply_Db1Context(DbContextOptions<DemandAndSupply_Db1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<DemandSupplyTbl2> DemandSupplyTbl2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LIN24006479\\SQLEXPRESS;Initial Catalog=DemandAndSupply_Db1; Integrated Security=true;");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<DemandSupplyTbl2>(entity =>
            {
                entity.ToTable("DemandSupply_Tbl2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Buaccount).HasColumnName("BUAccount");

                entity.Property(e => e.Buskills).HasColumnName("BUSkills");

                entity.Property(e => e.Busphandler).HasColumnName("BUSPHandler");

                entity.Property(e => e.DmdcaseStatus).HasColumnName("DMDCaseStatus");

                entity.Property(e => e.Fte).HasColumnName("FTE");

                entity.Property(e => e.MarketUnitBu).HasColumnName("MarketUnitBU");

                entity.Property(e => e.Psphandler).HasColumnName("PSPHandler");

                entity.Property(e => e.S2rcaseId).HasColumnName("S2RCaseId");

                entity.Property(e => e.S2rid).HasColumnName("S2RID");

                entity.Property(e => e.S2rmanaged).HasColumnName("S2RManaged");

                entity.Property(e => e.SellingBu).HasColumnName("SellingBU");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
