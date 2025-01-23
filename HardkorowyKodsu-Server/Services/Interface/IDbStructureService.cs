using HardkorowyKodsu_Server.Model.VOs;

namespace HardkorowyKodsu_Server.Services.Interface
{
    public interface IDbStructureService
    {
        /// <summary>
        /// Retrieves names of all tables and views in the database.
        /// </summary>
        /// <returns></returns>
        DBStructureVo GetStructure();
        /// <summary>
        /// Retrieves column data of a table.
        /// </summary>
        /// <param name="tableId">DB Id of the table.</param>
        /// <returns></returns>
        TableDataVo GetTableData(int tableId);
    }
}
