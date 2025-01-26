using HardkorowyKodsu_Server.Model.VOs;

namespace HardkorowyKodsu_Server.Services.Interface
{
    public interface IDbStructureService
    {
        /// <summary>
        /// Retrieves names of all tables and views in the database.
        /// </summary>
        /// <returns></returns>
        Task<DBStructureVo> GetStructure();
        /// <summary>
        /// Retrieves details of structural data of a table.
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        Task<TableDetailsDataVo> GetTableOrViewDetailsAsync(int tableId, char tableType);
        /// <summary>
        /// Retrieves columns data of a table.
        /// </summary>
        /// <param name="tableId">DB Id of the table.</param>
        /// <returns></returns>
        Task<TableColumnsDataVo> GetTableColumnsDataAsync(int tableId);
        ///// <summary>
        ///// Retrieves given single column for given table.
        ///// </summary>
        ///// <param name="tableId">Id of the table.</param>
        ///// <param name="columnId">Id of the column.</param>
        ///// <returns></returns>
        //Task<TableColumnVo> GetColumnDataAsync(int tableId, int columnId);
    }
}
