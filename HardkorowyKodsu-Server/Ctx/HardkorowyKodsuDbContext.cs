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
        public DbSet<TableModel> TableNameModels { get; set; }
        public DbSet<ViewModel> ViewNameModels { get; set; }
        public DbSet<TableColumnModel> TableColumnModels { get; set; }
        public DbSet<SchemaShortModel> SchemaShortModels { get; set; }
        public DbSet<DataTypeModel> DataTypeModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableModel>(tnmo =>
            {
                tnmo.ToTable(Constants.SysTablesName);
                tnmo.Property(tnm => tnm.Id).HasColumnName(Constants.SysTablesObjectIdName);
                tnmo.Property(tnm => tnm.Name).HasColumnName(Constants.SysTablesNameName);
                tnmo.Property(tnm => tnm.Type).HasColumnName(Constants.SysTablesTypeName);
                tnmo.Property(tnm => tnm.TypeDescription).HasColumnName(Constants.SysTablesTypeDescName);
                tnmo.Property(tnm => tnm.SchemaId).HasColumnName(Constants.SysTablesSchemaIdName);
                tnmo.Property(tnm => tnm.CreateDate).HasColumnName(Constants.SysTablesCreateDateName);
                tnmo.Property(tnm => tnm.ModifyDate).HasColumnName(Constants.SysTablesModifyDateName);
                tnmo.Property(tnm => tnm.IsPublished).HasColumnName(Constants.SysTablesIsPublishedName);
                tnmo.Property(tnm => tnm.IsSchemaPublished).HasColumnName(Constants.SysTablesIsSchemaPublishedName);
            });

            modelBuilder.Entity<ViewModel>(vnmo =>
            {
                vnmo.ToTable(Constants.SysViewsName);
                vnmo.Property(vnm => vnm.Id).HasColumnName(Constants.SysTablesObjectIdName);
                vnmo.Property(vnm => vnm.Name).HasColumnName(Constants.SysTablesNameName);
                vnmo.Property(vnm => vnm.Type).HasColumnName(Constants.SysTablesTypeName);
                vnmo.Property(vnm => vnm.TypeDescription).HasColumnName(Constants.SysTablesTypeDescName);
                vnmo.Property(vnm => vnm.SchemaId).HasColumnName(Constants.SysTablesSchemaIdName);
                vnmo.Property(vnm => vnm.CreateDate).HasColumnName(Constants.SysTablesCreateDateName);
                vnmo.Property(vnm => vnm.ModifyDate).HasColumnName(Constants.SysTablesModifyDateName);
                vnmo.Property(vnm => vnm.IsPublished).HasColumnName(Constants.SysTablesIsPublishedName);
                vnmo.Property(vnm => vnm.IsSchemaPublished).HasColumnName(Constants.SysTablesIsSchemaPublishedName);
            });

            modelBuilder.Entity<TableColumnModel>(tcmo =>
            {
                tcmo.ToTable(Constants.SysColumnsName);
                tcmo.Property(tcm => tcm.Id).HasColumnName(Constants.SysTablesColumnIdName);
                tcmo.Property(tcm => tcm.Name).HasColumnName(Constants.SysTablesNameName);
                tcmo.Property(tcm => tcm.UserTypeId).HasColumnName(Constants.SysTablesUserDataTypeIdName);
                tcmo.Property(tnm => tnm.MaxLength).HasColumnName(Constants.SysColumnsMaxLengthName);
                tcmo.Property(tnm => tnm.IsNullable).HasColumnName(Constants.SysColumnsIsNullableName);
                tcmo.Property(tnm => tnm.IsIdentity).HasColumnName(Constants.SysColumnsIsIdentityName);
                tcmo.Property(tnm => tnm.ParentObjectId).HasColumnName(Constants.SysColumnsParentObjectIdName);
                tcmo.Property(tnm => tnm.Precision).HasColumnName(Constants.SysDataTypesPrecisionName);
                tcmo.Property(tnm => tnm.Scale).HasColumnName(Constants.SysDataTypesScaleName);
            });

            modelBuilder.Entity<SchemaShortModel>(smso =>
            {
                smso.ToTable(Constants.SysSchemasName);
                smso.Property(sms => sms.Id).HasColumnName(Constants.SysTablesSchemaIdName);
                smso.Property(sms => sms.Name).HasColumnName(Constants.SysTablesNameName);
            });
            modelBuilder.Entity<DataTypeModel>(dto =>
            { 
                dto.ToTable(Constants.SysDataTypesName);
                dto.Property(dt => dt.Id).HasColumnName(Constants.SysTablesUserDataTypeIdName);
                dto.Property(dt => dt.Name).HasColumnName(Constants.SysTablesNameName);
                dto.Property(dt => dt.MaxLength).HasColumnName(Constants.SysDataTypesMaxLengthName);
                dto.Property(dt => dt.Precision).HasColumnName(Constants.SysDataTypesPrecisionName);
                dto.Property(dt => dt.Scale).HasColumnName(Constants.SysDataTypesScaleName);
                dto.Property(dt => dt.IsNullable).HasColumnName(Constants.SysDataTypesIsNullableName);
                dto.Property(dt => dt.IsUserDefined).HasColumnName(Constants.SysDataTypesIsUserDefinedName);
            });
        }

       
    }
}