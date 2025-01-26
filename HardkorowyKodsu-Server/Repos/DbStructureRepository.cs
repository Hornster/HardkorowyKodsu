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
        private const string _getTableNamesQuery =
            @$"SELECT {Constants.SysTablesNameName}
                , {Constants.SysTablesObjectIdName}
                , {Constants.SysTablesTypeName}
                , {Constants.SysTablesTypeDescName}
                , {Constants.SysTablesSchemaIdName}
                , {Constants.SysTablesCreateDateName}
                , {Constants.SysTablesModifyDateName}
                , {Constants.SysTablesIsPublishedName}
                , {Constants.SysTablesIsSchemaPublishedName}
               FROM {Constants.SysTablesName}";
        private const string _getViewNamesQuery =
            @$"SELECT {Constants.SysTablesNameName}
                , {Constants.SysTablesObjectIdName}
                , {Constants.SysTablesTypeName}
                , {Constants.SysTablesTypeDescName}
                , {Constants.SysTablesSchemaIdName} 
                , {Constants.SysTablesCreateDateName}
                , {Constants.SysTablesModifyDateName}
                , {Constants.SysTablesIsPublishedName}
                , {Constants.SysTablesIsSchemaPublishedName}
               FROM {Constants.SysViewsName}";
        private const string _tableIdParamName = "@tableId";
        private readonly string _getTableDetailsQuery = _getTableNamesQuery +
            @$" WHERE {Constants.SysTablesObjectIdName} = {_tableIdParamName}";
        private readonly string _getViewDetailsQuery = _getViewNamesQuery +
            @$" WHERE {Constants.SysTablesObjectIdName} = {_tableIdParamName}";
        private const string ColumnParentObjectIdParamName = "@parentObjectId";
        private readonly string _getTableColumnsQuery =
            @$"SELECT {Constants.SysTablesNameName}
                , {Constants.SysColumnsMaxLengthName}
                , {Constants.SysColumnsIsNullableName}
                , {Constants.SysColumnsIsIdentityName}
                , {Constants.SysTablesColumnIdName}
                , {Constants.SysTablesUserDataTypeIdName}
                , {Constants.SysColumnsParentObjectIdName}
                , {Constants.SysDataTypesPrecisionName}
                , {Constants.SysDataTypesScaleName}
               FROM {Constants.SysColumnsName} 
               WHERE {Constants.SysColumnsParentObjectIdName} = {ColumnParentObjectIdParamName}";
        private const string ColumnIdParamName = "@columnId";
        private readonly string _getTableColumnQuery =
            @$"SELECT {Constants.SysTablesTypeName}
                , {Constants.SysColumnsMaxLengthName}
                , {Constants.SysColumnsIsNullableName}
                , {Constants.SysColumnsIsIdentityName}
                , {Constants.SysTablesColumnIdName}
                , {Constants.SysTablesUserDataTypeIdName}
                , {Constants.SysColumnsParentObjectIdName}
                , {Constants.SysDataTypesPrecisionName}
                , {Constants.SysDataTypesScaleName}
            FROM {Constants.SysColumnsName} 
            WHERE {Constants.SysColumnsParentObjectIdName} = {ColumnParentObjectIdParamName}
                AND {Constants.SysColumnsColumnIdName} = {ColumnIdParamName}";


        public DbStructureRepository(IOptions<AppSettingsConfigModel> settings, HardkorowyKodsuDbContext dbContext) 
        {
            _dbContext = dbContext;
            _settings = settings;
        }
        public async Task<List<BaseTableModel>> GetStructureAsync()
        {
            var tableNameDbSet = _dbContext.TableNameModels;
            var viewNameDbSet = _dbContext.ViewNameModels;

            var result = new List<BaseTableModel>();
            var formattedTablesQuery = FormattableStringFactory.Create(_getTableNamesQuery);
            var formattedViewsQuery = FormattableStringFactory.Create(_getViewNamesQuery);

            var tableNames = await tableNameDbSet.FromSql(formattedTablesQuery).ToListAsync();
            var viewNames = await viewNameDbSet.FromSql(formattedViewsQuery).ToListAsync();

            result.AddRange(tableNames);
            result.AddRange(viewNames);

            return result;
        }
        private async Task<BaseTableModel> GetTableDetailsAsync(int tableId, string query)
        {
            var tableColumnDbSet = _dbContext.TableNameModels;
            var param = new SqlParameter(_tableIdParamName, tableId);
            var formattedQuery = FormattableStringFactory.Create(query, param);
            var tableDetails = await tableColumnDbSet.FromSql(formattedQuery).FirstAsync();
            return tableDetails;
        }

        public async Task<BaseTableModel> GetTableOrViewDetailsAsync(int tableId, char tableType)
        {
            switch(tableType)
            {
                case Constants.TableMarker:
                    return await GetTableDetailsAsync(tableId, _getTableDetailsQuery);
                case Constants.ViewMarker:
                    return await GetTableDetailsAsync(tableId, _getViewDetailsQuery);
                default:
                    throw new ArgumentException("Invalid table type.");
            }
        }

        public async Task<TableDataModel> GetTableColumnsAsync(int tableId)
        {
            var tableColumnDbSet = _dbContext.TableColumnModels;
            var param = new SqlParameter(ColumnParentObjectIdParamName, tableId);
            var formattedQuery = FormattableStringFactory.Create(_getTableColumnsQuery, param);
            var tableColumns = await tableColumnDbSet.FromSql(formattedQuery).ToListAsync();

            return new TableDataModel { Columns = tableColumns };
        }

        public async Task<TableColumnModel> GetColumnDataAsync(int tableId, int columnId)
        {
            var tableColumnDbSet = _dbContext.TableColumnModels;
            var paramTableId = new SqlParameter(ColumnParentObjectIdParamName, tableId);
            var paramColumnId = new SqlParameter(ColumnIdParamName, columnId);
            var formattedQuery = FormattableStringFactory.Create(_getTableColumnQuery, paramTableId, paramColumnId);
            var tableColumn = await tableColumnDbSet.FromSql(formattedQuery).FirstAsync();

            return tableColumn;
        }
    }
}
