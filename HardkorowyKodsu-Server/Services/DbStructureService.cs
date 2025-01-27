using AutoMapper;
using HardkorowyKodsu_Server.Model.DB;
using HardkorowyKodsu_Server.Model.VOs;
using HardkorowyKodsu_Server.Repos;
using HardkorowyKodsu_Server.Repos.Interface;
using HardkorowyKodsu_Server.Services.Interface;

namespace HardkorowyKodsu_Server.Services
{
    public class DbStructureService : BaseService, IDbStructureService
    {
        private readonly IDbStructureRepository _dbStructureRepository;
        private readonly ISchemaRepository _schemaRepository;
        private readonly IDataTypesRepository _dataTypesRepository;

        public DbStructureService(IMapper mapper, IDbStructureRepository dbStructureRepository
            , ISchemaRepository schemaRepository, IDataTypesRepository dataTypesRepository) : base(mapper)
        {
            _dbStructureRepository = dbStructureRepository;
            _schemaRepository = schemaRepository;
            _dataTypesRepository = dataTypesRepository;
        }


        /// <inheritdoc />
        public async Task<DBStructureVo> GetStructure()
        {
            var dbStructure = await _dbStructureRepository.GetStructureAsync();
            var schemas = await _schemaRepository.GetAllSchemasAsync();

            var mappedStructure = _mapper.Map<List<BaseTableModel>, List<TableNameVo>>(dbStructure);
            //sys.tables and sys.views require separate models but there is only one sys.schema.
            //Have to join them this way to get the schema name for each table instead of through EF.
            var tableNamesWithSchemas = from schema in schemas
                join table in mappedStructure on schema.Id equals table.SchemaId
            select new { table, schema };

            foreach (var item in tableNamesWithSchemas)
            {
                item.table.SchemaName = item.schema.Name;
            }

            var dbStructureVo = new DBStructureVo
            {
                Tables = mappedStructure
            };

            return dbStructureVo;
        }
        /// <inheritdoc />
        public async Task<TableColumnsDataVo> GetTableColumnsDataAsync(int tableId)
        {
            var tableData = await _dbStructureRepository.GetTableColumnsAsync(tableId);

            var mappedTableData = _mapper.Map<TableDataModel, TableColumnsDataVo>(tableData);

            var columnUserTypeIds = mappedTableData.Columns.Select(c => c.UserTypeId).ToList();
            var dataTypes = await _dataTypesRepository.GetDataTypesAsync(columnUserTypeIds);

            var columnDatatypePairs = from column in mappedTableData.Columns
                join dataType in dataTypes on column.UserTypeId equals dataType.Id
            select new { column, dataType };

            foreach (var item in columnDatatypePairs)
            {
                item.column.DataType = item.dataType.Name;
            }

            mappedTableData.Columns = mappedTableData.Columns.OrderBy(c => c.Name).ToList();

            return mappedTableData;
        }

        /// <inheritdoc />
        public async Task<TableDetailsDataVo> GetTableOrViewDetailsAsync(int tableId, char tableType)
        {
            var tableData = await _dbStructureRepository.GetTableOrViewDetailsAsync(tableId, tableType);

            var mappedTableData = _mapper.Map<BaseTableModel, TableDetailsDataVo>(tableData);

            var schema = await _schemaRepository.GetSchemaByIdAsync(mappedTableData.SchemaId);

            mappedTableData.SchemaName = schema.Name;

            return mappedTableData;
        }
    }
}
