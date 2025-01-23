using HardkorowyKodsu_Server.Model.DTOs;

namespace HardkorowyKodsu_Server.Repos.Interface
{
    public interface IDbStructureRepository
    {
        /// <summary>
        /// Retrieves names of all tables and views in the database.
        /// </summary>
        /// <returns></returns>
        List<TableNameModel> GetStructure();
        /// <summary>
        /// Retrieves column data of a table.
        /// </summary>
        /// <param name="tableId">DB Id of the table.</param>
        /// <returns></returns>
        TableDataModel GetTableData(int tableId);
    }
}
