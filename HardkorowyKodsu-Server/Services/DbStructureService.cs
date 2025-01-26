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

        public DbStructureService(IMapper mapper, IDbStructureRepository dbStructureRepository, ISchemaRepository schemaRepository) : base(mapper)
        {
            _dbStructureRepository = dbStructureRepository;
            _schemaRepository = schemaRepository;
        }


        public async Task<DBStructureVo> GetStructure()
        {
            var dbStructure = await _dbStructureRepository.GetStructureAsync();
            var schemas = await _schemaRepository.GetAllSchemasAsync();

            var mappedStructure = _mapper.Map<List<BaseTableNameModel>, List<TableNameVo>>(dbStructure);
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

        public TableDataVo GetTableData(int tableId)
        {
            var getTableDataTask = _dbStructureRepository.GetTableData(tableId);
            getTableDataTask.Wait();
            var tableData = getTableDataTask.Result;
            var mappedTableData = _mapper.Map<TableDataVo>(tableData);
            return mappedTableData;
        }
    }
}
