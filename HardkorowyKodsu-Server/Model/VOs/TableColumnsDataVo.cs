namespace HardkorowyKodsu_Server.Model.VOs
{
    /// <summary>
    /// Viewobject containing the columns of a table.
    /// </summary>
    public class TableColumnsDataVo : TableNameVo
    {
        /// <summary>
        /// Structural description of the columns of the table.
        /// </summary>
        public List<TableColumnVo> Columns { get; set; }
    }
}
