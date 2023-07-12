using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DemandAndSupply_FileUpload.Models
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

        public virtual DbSet<DemandAndSupplyTbl> DemandAndSupplyTbls { get; set; }
        public virtual DbSet<DemandSupplyTbl1> DemandSupplyTbl1s { get; set; }
        public virtual DbSet<DemandSupplyTbl2> DemandSupplyTbl2s { get; set; }
        public virtual DbSet<DemandSupplyTbl3> DemandSupplyTbl3s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LIN22006027\\SQLEXPRESS; Initial Catalog=DemandAndSupply_Db1; Integrated Security=true;");
            }*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<DemandAndSupplyTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DemandAndSupply_Tbl");

                entity.Property(e => e.AccountGeoCity).HasMaxLength(50);

                entity.Property(e => e.AccountGeoName).HasMaxLength(50);

                entity.Property(e => e.AccountRegion).HasMaxLength(50);

                entity.Property(e => e.AgedPastDue).HasMaxLength(20);

                entity.Property(e => e.Ageing).HasMaxLength(50);

                entity.Property(e => e.AssignedTo).HasMaxLength(50);

                entity.Property(e => e.BackFillReason).HasMaxLength(50);

                entity.Property(e => e.Buaccount)
                    .HasMaxLength(100)
                    .HasColumnName("BUAccount");

                entity.Property(e => e.Buskills)
                    .HasMaxLength(20)
                    .HasColumnName("BUSkills");

                entity.Property(e => e.Busphandler)
                    .HasMaxLength(50)
                    .HasColumnName("BUSPHandler");

                entity.Property(e => e.CandidateCount).HasMaxLength(20);

                entity.Property(e => e.Client).HasMaxLength(100);

                entity.Property(e => e.ClientLocation).HasMaxLength(50);

                entity.Property(e => e.ClientReference).HasMaxLength(50);

                entity.Property(e => e.ClosestGeoHub).HasMaxLength(50);

                entity.Property(e => e.CountryOfDelivery).HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.DaysSincePastDue).HasMaxLength(20);

                entity.Property(e => e.DeliveryRole).HasMaxLength(100);

                entity.Property(e => e.DeliverySkills).HasMaxLength(100);

                entity.Property(e => e.DeliveryType).HasMaxLength(50);

                entity.Property(e => e.DemandFulfillmentStatus).HasMaxLength(50);

                entity.Property(e => e.DemandGeo).HasMaxLength(50);

                entity.Property(e => e.DemandStatus).HasMaxLength(100);

                entity.Property(e => e.DemandType).HasMaxLength(100);

                entity.Property(e => e.DmdcaseStatus)
                    .HasMaxLength(50)
                    .HasColumnName("DMDCaseStatus");

                entity.Property(e => e.DurationInAgedPastStatus).HasMaxLength(20);

                entity.Property(e => e.ExcludeOffshore).HasMaxLength(20);

                entity.Property(e => e.ExpectedDailyRate).HasMaxLength(20);

                entity.Property(e => e.ForecastType).HasMaxLength(20);

                entity.Property(e => e.Fte)
                    .HasMaxLength(20)
                    .HasColumnName("FTE");

                entity.Property(e => e.FulfillmentChannelFinal).HasMaxLength(50);

                entity.Property(e => e.GlobalGrade).HasMaxLength(20);

                entity.Property(e => e.GlobalPractice).HasMaxLength(50);

                entity.Property(e => e.HeadCountType).HasMaxLength(20);

                entity.Property(e => e.Hub).HasMaxLength(50);

                entity.Property(e => e.IsClientInterviewRequired).HasMaxLength(20);

                entity.Property(e => e.JobName).HasMaxLength(100);

                entity.Property(e => e.LeadMarketAndPractice).HasMaxLength(20);

                entity.Property(e => e.LeadMarketArea).HasMaxLength(100);

                entity.Property(e => e.LeadPracticeArea).HasMaxLength(100);

                entity.Property(e => e.LeadtimeInDays).HasMaxLength(50);

                entity.Property(e => e.LocalGrade).HasMaxLength(20);

                entity.Property(e => e.LocationDescription).HasMaxLength(100);

                entity.Property(e => e.MarketUnitBu)
                    .HasMaxLength(20)
                    .HasColumnName("MarketUnitBU");

                entity.Property(e => e.MicroSector).HasMaxLength(100);

                entity.Property(e => e.OutgoingEmployee).HasMaxLength(50);

                entity.Property(e => e.PositionId).HasMaxLength(50);

                entity.Property(e => e.PositionName).HasMaxLength(100);

                entity.Property(e => e.Practice).HasMaxLength(20);

                entity.Property(e => e.PrimaryCity).HasMaxLength(100);

                entity.Property(e => e.PrimaryGeoCity).HasMaxLength(50);

                entity.Property(e => e.PrimaryGeoName).HasMaxLength(50);

                entity.Property(e => e.PrimaryLocationName).HasMaxLength(100);

                entity.Property(e => e.PrimaryRegion).HasMaxLength(50);

                entity.Property(e => e.PrimaryState).HasMaxLength(100);

                entity.Property(e => e.PrimaryZipCode).HasMaxLength(100);

                entity.Property(e => e.ProductionUnit).HasMaxLength(50);

                entity.Property(e => e.ProductionUnitName).HasMaxLength(50);

                entity.Property(e => e.ProjectCode).HasMaxLength(100);

                entity.Property(e => e.Psphandler)
                    .HasMaxLength(100)
                    .HasColumnName("PSPHandler");

                entity.Property(e => e.Recruiter).HasMaxLength(50);

                entity.Property(e => e.RecruitingId).HasMaxLength(50);

                entity.Property(e => e.RequestCreator).HasMaxLength(50);

                entity.Property(e => e.RequestUpdater).HasMaxLength(100);

                entity.Property(e => e.RequestedBy).HasMaxLength(100);

                entity.Property(e => e.RequisitionLocation).HasMaxLength(50);

                entity.Property(e => e.RoleComment).HasMaxLength(100);

                entity.Property(e => e.RoleEndDate).HasColumnType("date");

                entity.Property(e => e.RoleStartDate).HasColumnType("date");

                entity.Property(e => e.RoleType).HasMaxLength(50);

                entity.Property(e => e.S2rcaseId)
                    .HasMaxLength(50)
                    .HasColumnName("S2RCaseId");

                entity.Property(e => e.S2rid)
                    .HasMaxLength(50)
                    .HasColumnName("S2RID");

                entity.Property(e => e.S2rmanaged)
                    .HasMaxLength(20)
                    .HasColumnName("S2RManaged");

                entity.Property(e => e.SelfAppliedApplications).HasMaxLength(20);

                entity.Property(e => e.SellingBu)
                    .HasMaxLength(100)
                    .HasColumnName("SellingBU");

                entity.Property(e => e.SourceInfo).HasMaxLength(50);

                entity.Property(e => e.SourceOfDemand).HasMaxLength(50);

                entity.Property(e => e.SubSector).HasMaxLength(100);

                entity.Property(e => e.TargetBillRate).HasMaxLength(50);

                entity.Property(e => e.TaskLabel).HasMaxLength(50);

                entity.Property(e => e.TeamRequestComment).HasMaxLength(50);

                entity.Property(e => e.TeamRequestId).HasMaxLength(50);

                entity.Property(e => e.TeamRequestName).HasMaxLength(150);

                entity.Property(e => e.TeamRequestStatus).HasMaxLength(50);

                entity.Property(e => e.ThorCloseDate).HasColumnType("date");

                entity.Property(e => e.ThorContractType).HasMaxLength(20);

                entity.Property(e => e.ThorOptyId).HasMaxLength(50);

                entity.Property(e => e.ThorProbability).HasMaxLength(20);

                entity.Property(e => e.ThorStage).HasMaxLength(20);

                entity.Property(e => e.ThorStartDate).HasColumnType("date");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");

                entity.Property(e => e.Visible).HasMaxLength(50);

                entity.Property(e => e.WeekByStatus).HasMaxLength(50);

                entity.Property(e => e.WeekByStatusGrouped).HasMaxLength(20);
            });

            modelBuilder.Entity<DemandSupplyTbl1>(entity =>
            {
                entity.ToTable("DemandSupply_Tbl1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountGeoCity).HasMaxLength(50);

                entity.Property(e => e.AccountGeoName).HasMaxLength(50);

                entity.Property(e => e.AccountRegion).HasMaxLength(50);

                entity.Property(e => e.AgedPastDue).HasMaxLength(20);

                entity.Property(e => e.Ageing).HasMaxLength(50);

                entity.Property(e => e.AssignedTo).HasMaxLength(50);

                entity.Property(e => e.BackFillReason).HasMaxLength(50);

                entity.Property(e => e.Buaccount)
                    .HasMaxLength(100)
                    .HasColumnName("BUAccount");

                entity.Property(e => e.Buskills)
                    .HasMaxLength(20)
                    .HasColumnName("BUSkills");

                entity.Property(e => e.Busphandler)
                    .HasMaxLength(50)
                    .HasColumnName("BUSPHandler");

                entity.Property(e => e.CandidateCount).HasMaxLength(20);

                entity.Property(e => e.Client).HasMaxLength(100);

                entity.Property(e => e.ClientLocation).HasMaxLength(50);

                entity.Property(e => e.ClientReference).HasMaxLength(50);

                entity.Property(e => e.ClosestGeoHub).HasMaxLength(50);

                entity.Property(e => e.CountryOfDelivery).HasMaxLength(50);

                entity.Property(e => e.DaysSincePastDue).HasMaxLength(20);

                entity.Property(e => e.DeliveryRole).HasMaxLength(100);

                entity.Property(e => e.DeliverySkills).HasMaxLength(100);

                entity.Property(e => e.DeliveryType).HasMaxLength(50);

                entity.Property(e => e.DemandFulfillmentStatus).HasMaxLength(50);

                entity.Property(e => e.DemandGeo).HasMaxLength(50);

                entity.Property(e => e.DemandStatus).HasMaxLength(100);

                entity.Property(e => e.DemandType).HasMaxLength(100);

                entity.Property(e => e.DmdcaseStatus)
                    .HasMaxLength(50)
                    .HasColumnName("DMDCaseStatus");

                entity.Property(e => e.DurationInAgedPastStatus).HasMaxLength(20);

                entity.Property(e => e.ExcludeOffshore).HasMaxLength(20);

                entity.Property(e => e.ExpectedDailyRate).HasMaxLength(20);

                entity.Property(e => e.ForecastType).HasMaxLength(20);

                entity.Property(e => e.Fte)
                    .HasMaxLength(20)
                    .HasColumnName("FTE");

                entity.Property(e => e.FulfillmentChannelFinal).HasMaxLength(50);

                entity.Property(e => e.GlobalGrade).HasMaxLength(20);

                entity.Property(e => e.GlobalPractice).HasMaxLength(50);

                entity.Property(e => e.HeadCountType).HasMaxLength(20);

                entity.Property(e => e.Hub).HasMaxLength(50);

                entity.Property(e => e.IsClientInterviewRequired).HasMaxLength(20);

                entity.Property(e => e.JobName).HasMaxLength(100);

                entity.Property(e => e.LeadMarketAndPractice).HasMaxLength(20);

                entity.Property(e => e.LeadMarketArea).HasMaxLength(100);

                entity.Property(e => e.LeadPracticeArea).HasMaxLength(100);

                entity.Property(e => e.LeadtimeInDays).HasMaxLength(50);

                entity.Property(e => e.LocalGrade).HasMaxLength(20);

                entity.Property(e => e.LocationDescription).HasMaxLength(100);

                entity.Property(e => e.MarketUnitBu)
                    .HasMaxLength(20)
                    .HasColumnName("MarketUnitBU");

                entity.Property(e => e.MicroSector).HasMaxLength(100);

                entity.Property(e => e.OutgoingEmployee).HasMaxLength(50);

                entity.Property(e => e.PositionId).HasMaxLength(50);

                entity.Property(e => e.PositionName).HasMaxLength(100);

                entity.Property(e => e.Practice).HasMaxLength(20);

                entity.Property(e => e.PrimaryCity).HasMaxLength(100);

                entity.Property(e => e.PrimaryGeoCity).HasMaxLength(50);

                entity.Property(e => e.PrimaryGeoName).HasMaxLength(50);

                entity.Property(e => e.PrimaryLocationName).HasMaxLength(100);

                entity.Property(e => e.PrimaryRegion).HasMaxLength(50);

                entity.Property(e => e.PrimaryState).HasMaxLength(100);

                entity.Property(e => e.PrimaryZipCode).HasMaxLength(100);

                entity.Property(e => e.ProductionUnit).HasMaxLength(50);

                entity.Property(e => e.ProductionUnitName).HasMaxLength(50);

                entity.Property(e => e.ProjectCode).HasMaxLength(100);

                entity.Property(e => e.Psphandler)
                    .HasMaxLength(100)
                    .HasColumnName("PSPHandler");

                entity.Property(e => e.Recruiter).HasMaxLength(50);

                entity.Property(e => e.RecruitingId).HasMaxLength(50);

                entity.Property(e => e.RequestCreator).HasMaxLength(50);

                entity.Property(e => e.RequestUpdater).HasMaxLength(100);

                entity.Property(e => e.RequestedBy).HasMaxLength(100);

                entity.Property(e => e.RequisitionLocation).HasMaxLength(50);

                entity.Property(e => e.RoleComment).HasMaxLength(100);

                entity.Property(e => e.RoleType).HasMaxLength(50);

                entity.Property(e => e.S2rcaseId)
                    .HasMaxLength(50)
                    .HasColumnName("S2RCaseId");

                entity.Property(e => e.S2rid)
                    .HasMaxLength(50)
                    .HasColumnName("S2RID");

                entity.Property(e => e.S2rmanaged)
                    .HasMaxLength(20)
                    .HasColumnName("S2RManaged");

                entity.Property(e => e.SelfAppliedApplications).HasMaxLength(20);

                entity.Property(e => e.SellingBu)
                    .HasMaxLength(100)
                    .HasColumnName("SellingBU");

                entity.Property(e => e.SourceInfo).HasMaxLength(50);

                entity.Property(e => e.SourceOfDemand).HasMaxLength(50);

                entity.Property(e => e.SubSector).HasMaxLength(100);

                entity.Property(e => e.TargetBillRate).HasMaxLength(50);

                entity.Property(e => e.TaskLabel).HasMaxLength(50);

                entity.Property(e => e.TeamRequestComment).HasMaxLength(50);

                entity.Property(e => e.TeamRequestId).HasMaxLength(50);

                entity.Property(e => e.TeamRequestName).HasMaxLength(150);

                entity.Property(e => e.TeamRequestStatus).HasMaxLength(50);

                entity.Property(e => e.ThorContractType).HasMaxLength(20);

                entity.Property(e => e.ThorOptyId).HasMaxLength(50);

                entity.Property(e => e.ThorProbability).HasMaxLength(20);

                entity.Property(e => e.ThorStage).HasMaxLength(20);

                entity.Property(e => e.Visible).HasMaxLength(50);

                entity.Property(e => e.WeekByStatus).HasMaxLength(50);

                entity.Property(e => e.WeekByStatusGrouped).HasMaxLength(20);
            });

            modelBuilder.Entity<DemandSupplyTbl2>(entity =>
            {
                entity.ToTable("DemandSupply_Tbl2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Buaccount).HasColumnName("BUAccount");

                entity.Property(e => e.Buskills).HasColumnName("BUSkills");

                entity.Property(e => e.Busphandler).HasColumnName("BUSPHandler");

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.DmdcaseStatus).HasColumnName("DMDCaseStatus");

                entity.Property(e => e.Fte).HasColumnName("FTE");

                entity.Property(e => e.MarketUnitBu).HasColumnName("MarketUnitBU");

                entity.Property(e => e.Psphandler).HasColumnName("PSPHandler");

                entity.Property(e => e.RoleEndDate).HasColumnType("date");

                entity.Property(e => e.RoleStartDate).HasColumnType("date");

                entity.Property(e => e.S2rcaseId).HasColumnName("S2RCaseId");

                entity.Property(e => e.S2rid).HasColumnName("S2RID");

                entity.Property(e => e.S2rmanaged).HasColumnName("S2RManaged");

                entity.Property(e => e.SellingBu).HasColumnName("SellingBU");

                entity.Property(e => e.ThorCloseDate).HasColumnType("date");

                entity.Property(e => e.ThorStartDate).HasColumnType("date");

                entity.Property(e => e.UpdatedOn).HasColumnType("date");
            });

            modelBuilder.Entity<DemandSupplyTbl3>(entity =>
            {
                entity.ToTable("DemandSupply_Tbl3");

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
