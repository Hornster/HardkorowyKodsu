using HardkorowyKodsu_Server.Model.DTOs;
using HardkorowyKodsu_Server.Repos.Interface;
using Microsoft.EntityFrameworkCore;

namespace HardkorowyKodsu_Server.Repos
{
    public class DbStructureRepository : IDbStructureRepository
    {
        protected readonly DbContext _dbContext;
        public DbStructureRepository(DbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public List<TableNameModel> GetStructure()
        {
            var sqlQuery = "SELECT * FROM INFORMATION_SCHEMA.TABLES";
            throw new NotImplementedException();

        }
        public TableDataModel GetTableData(int tableId)
        {
            throw new NotImplementedException();
        }
    }
}
