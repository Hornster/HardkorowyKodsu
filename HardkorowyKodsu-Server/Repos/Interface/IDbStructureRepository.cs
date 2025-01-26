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
        /// <summary>
        /// Retrieves given single column for given table.
        /// </summary>
        /// <param name="tableId">ID of the table which the column belongs to.</param>
        /// <param name="columnId">ID of the column itself.</param>
        /// <returns></returns>
        Task<TableColumnModel> GetColumnDataAsync(int tableId, int columnId);
    }
}
