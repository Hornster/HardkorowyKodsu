using HardkorowyKodsu_Server.Common.Const;
using HardkorowyKodsu_Server.Model.DB;
using Microsoft.EntityFrameworkCore;

namespace HardkorowyKodsu_Server.Ctx
{
    public class HardkorowyKodsuDbContext : DbContext
    {
        public HardkorowyKodsuDbContext(DbContextOptions<HardkorowyKodsuDbContext> options) : base(options)
        {
        }
        public DbSet<TableNameModel> TableNameModels { get; set; }
        public DbSet<ViewNameModel> ViewNameModels { get; set; }
        public DbSet<TableColumnModel> TableColumnModels { get; set; }
        public DbSet<SchemaShortModel> SchemaShortModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableNameModel>(tnmo =>
            {
                tnmo.ToTable(Constants.SysTablesName);
                tnmo.Property(tnm => tnm.Id).HasColumnName(Constants.SysTablesObjectIdName);
                tnmo.Property(tnm => tnm.Name).HasColumnName(Constants.SysTablesNameName);
                tnmo.Property(tnm => tnm.Type).HasColumnName(Constants.SysTablesTypeName);
                tnmo.Property(tnm => tnm.TypeDescription).HasColumnName(Constants.SysTablesTypeDescName);
                tnmo.Property(tnm => tnm.SchemaId).HasColumnName(Constants.SysTablesSchemaIdName);
            });

            modelBuilder.Entity<ViewNameModel>(vnmo =>
            {
                vnmo.ToTable(Constants.SysViewsName);
                vnmo.Property(vnm => vnm.Id).HasColumnName(Constants.SysTablesObjectIdName);
                vnmo.Property(vnm => vnm.Name).HasColumnName(Constants.SysTablesNameName);
                vnmo.Property(vnm => vnm.Type).HasColumnName(Constants.SysTablesTypeName);
                vnmo.Property(vnm => vnm.TypeDescription).HasColumnName(Constants.SysTablesTypeDescName);
                vnmo.Property(vnm => vnm.SchemaId).HasColumnName(Constants.SysTablesSchemaIdName);
            });

            modelBuilder.Entity<TableColumnModel>(tcmo =>
            {
                tcmo.ToTable(Constants.SysColumnsName);
                tcmo.Property(tcm => tcm.Id).HasColumnName(Constants.SysTablesColumnIdName);
                tcmo.Property(tcm => tcm.Name).HasColumnName(Constants.SysTablesNameName);
                tcmo.Property(tcm => tcm.SystemType).HasColumnName(Constants.SysTablesUserDataTypeIdName);
                tcmo.Property(tcm => tcm.UserType).HasColumnName(Constants.SysTablesSystemDataTypeIdName);
                tcmo.Property(tnm => tnm.Length).HasColumnName(Constants.SysColumnsMaxLengthName);
                tcmo.Property(tnm => tnm.IsNullable).HasColumnName(Constants.SysColumnsIsNullableName);
                tcmo.Property(tnm => tnm.IsIdentity).HasColumnName(Constants.SysColumnsIsIdentityName);
                tcmo.Property(tnm => tnm.IsPrimaryKey).HasColumnName(Constants.SysColumnsIsPrimaryKeyName);
                tcmo.Property(tnm => tnm.OrdinalPosition).HasColumnName(Constants.SysColumnsOrdinalPositionName);
                tcmo.Property(tnm => tnm.DefaultValue).HasColumnName(Constants.SysColumnsDefaultValueName);
                tcmo.Property(tnm => tnm.ParentObjectId).HasColumnName(Constants.SysColumnsParentObjectIdName);
            });

            modelBuilder.Entity<SchemaShortModel>(smso =>
            {
                smso.ToTable(Constants.SysSchemasName);
                smso.Property(sms => sms.Id).HasColumnName(Constants.SysTablesSchemaIdName);
                smso.Property(sms => sms.Name).HasColumnName(Constants.SysTablesNameName);
            });
        }

       
    }
}
//https://learn.microsoft.com/en-us/ef/core/modeling/table-splitting