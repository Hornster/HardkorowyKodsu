using HardkorowyKodsu_Server.Model.DB;

namespace HardkorowyKodsu_Server.Repos.Interface
{
    public interface IDbStructureRepository
    {
        /// <summary>
        /// Retrieves names of all tables and views in the database.
        /// </summary>
        /// <returns></returns>
        Task<List<BaseTableModel>> GetStructureAsync();
        /// <summary>
        /// Retrieves detailed info on a table or view. Does not return columns.
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="tableType"></param>
        /// <returns></returns>
        Task<BaseTableModel> GetTableOrViewDetailsAsync(int tableId, char tableType);
        /// <summary>
        /// Retrieves column data of a table.
        /// </summary>
        /// <param name="tableId">DB Id of the table.</param>
        /// <returns></returns>
        Task<TableDataModel> GetTableColumnsAsync(int tableId);
    }
}
