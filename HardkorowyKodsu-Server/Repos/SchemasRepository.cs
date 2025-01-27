using HardkorowyKodsu_Server.Common.Const;
using HardkorowyKodsu_Server.Ctx;
using HardkorowyKodsu_Server.Model.DB;
using HardkorowyKodsu_Server.Repos.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace HardkorowyKodsu_Server.Repos
{
    public class SchemaRepository : ISchemaRepository
    {
        private readonly HardkorowyKodsuDbContext _dbContext;
        private const string _getSchemasQuery =
            @$"SELECT {Constants.SysTablesNameName}, {Constants.SysTablesSchemaIdName} 
               FROM {Constants.SysSchemasName}";
        private const string _schemaIdParamName = "@schemaId";
        private readonly string _getSchemaQuery = _getSchemasQuery +
               @$" WHERE {Constants.SysTablesSchemaIdName} = {_schemaIdParamName}";

        public SchemaRepository(HardkorowyKodsuDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        /// <inheritdoc/>
        public async Task<List<SchemaShortModel>> GetAllSchemasAsync()
        {
            var schemasDbSet = _dbContext.SchemaShortModels;
            var formattedSchemasQuery = FormattableStringFactory.Create(_getSchemasQuery);
            var schemas = await schemasDbSet.FromSql(formattedSchemasQuery).ToListAsync();

            return schemas;
        }
        /// <inheritdoc/>
        public async Task<SchemaShortModel> GetSchemaByIdAsync(int schemaId)
        {
            var schemasDbSet = _dbContext.SchemaShortModels;
            var param = new SqlParameter(_schemaIdParamName, schemaId);
            var formattedSchemasQuery = FormattableStringFactory.Create(_getSchemaQuery, param);
            var schema = await schemasDbSet.FromSql(formattedSchemasQuery).FirstAsync();

            return schema;
        }
    }
}
