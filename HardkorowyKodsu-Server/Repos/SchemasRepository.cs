using HardkorowyKodsu_Server.Common.Const;
using HardkorowyKodsu_Server.Ctx;
using HardkorowyKodsu_Server.Model.DB;
using HardkorowyKodsu_Server.Repos.Interface;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace HardkorowyKodsu_Server.Repos
{
    public class SchemaRepository : ISchemaRepository
    {
        private readonly HardkorowyKodsuDbContext _dbContext;
        private readonly string _getSchemasQuery =
            @$"SELECT {Constants.SysTablesNameName}, {Constants.SysTablesSchemaIdName} FROM {Constants.SysSchemasName}";

        public SchemaRepository(HardkorowyKodsuDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<List<SchemaShortModel>> GetAllSchemasAsync()
        {
            var schemasDbSet = _dbContext.SchemaShortModels;
            var formattedSchemasQuery = FormattableStringFactory.Create(_getSchemasQuery);
            var schemas = await schemasDbSet.FromSql(formattedSchemasQuery).ToListAsync();

            return schemas;
        }
    }
}
