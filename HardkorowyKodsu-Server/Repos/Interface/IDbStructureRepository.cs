using HardkorowyKodsu_Server.Model.DB;

namespace HardkorowyKodsu_Server.Repos.Interface
{
    public interface IDbStructureRepository
    {
        /// <summary>
        /// Retrieves names of all tables and views in the database.
        /// </summary>
        /// <returns></returns>
        Task<List<BaseTableNameModel>> GetStructureAsync();
        /// <summary>
        /// Retrieves column data of a table.
        /// </summary>
        /// <param name="tableId">DB Id of the table.</param>
        /// <returns></returns>
        Task<TableDataModel> GetTableData(int tableId);
    }
}
