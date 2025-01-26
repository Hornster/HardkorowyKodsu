using HardkorowyKodsu_Server.Common.Const;
using HardkorowyKodsu_Server.Config;
using HardkorowyKodsu_Server.Ctx;
using HardkorowyKodsu_Server.Model.DB;
using HardkorowyKodsu_Server.Repos.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HardkorowyKodsu_Server.Repos
{
    public class DbStructureRepository : IDbStructureRepository
    {
        private readonly HardkorowyKodsuDbContext _dbContext;
        private readonly IOptions<AppSettingsConfigModel> _settings;
        private readonly string _getTableNamesQuery =
            @$"SELECT {Constants.SysTablesNameName}, {Constants.SysTablesObjectIdName}, {Constants.SysTablesTypeName}, {Constants.SysTablesTypeDescName}, {Constants.SysTablesSchemaIdName}
               FROM {Constants.SysTablesName}";
        private readonly string _getViewNamesQuery =
            @$"SELECT {Constants.SysTablesNameName}, {Constants.SysTablesObjectIdName}, {Constants.SysTablesTypeName}, {Constants.SysTablesTypeDescName}, {Constants.SysTablesSchemaIdName} 
               FROM {Constants.SysViewsName}";
        private const string ColumnParentObjectIdParamName = "@parentObjectId";
        private readonly string _getTableColumnsQuery =
            @$"SELECT * FROM {Constants.SysColumnsName} WHERE {Constants.SysColumnsParentObjectIdName} = {ColumnParentObjectIdParamName}";
        

        public DbStructureRepository(IOptions<AppSettingsConfigModel> settings, HardkorowyKodsuDbContext dbContext) 
        {
            _dbContext = dbContext;
            _settings = settings;
        }
        public async Task<List<BaseTableNameModel>> GetStructureAsync()
        {
            var tableNameDbSet = _dbContext.TableNameModels;
            var viewNameDbSet = _dbContext.ViewNameModels;

            var result = new List<BaseTableNameModel>();
            var formattedTablesQuery = FormattableStringFactory.Create(_getTableNamesQuery);
            var formattedViewsQuery = FormattableStringFactory.Create(_getViewNamesQuery);

            var tableNames = await tableNameDbSet.FromSql(formattedTablesQuery).ToListAsync();
            var viewNames = await viewNameDbSet.FromSql(formattedViewsQuery).ToListAsync();

            result.AddRange(tableNames);
            result.AddRange(viewNames);

            return result;
        }
        public async Task<TableDataModel> GetTableData(int tableId)
        {
            var tableColumnDbSet = _dbContext.TableColumnModels;
            var param = new SqlParameter(ColumnParentObjectIdParamName, tableId);
            var formattedQuery = FormattableStringFactory.Create(_getTableColumnsQuery, param);
            var tableColumns = await tableColumnDbSet.FromSql(formattedQuery).ToListAsync();

            return new TableDataModel { Columns = tableColumns };
        }
    }
}
