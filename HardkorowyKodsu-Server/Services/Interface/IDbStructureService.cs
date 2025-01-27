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
    }
}
