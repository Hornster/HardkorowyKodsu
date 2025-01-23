namespace HardkorowyKodsu_Server.Model.VOs
{
    /// <summary>
    /// Viewobject containing the structure of a table.
    /// </summary>
    public class TableDataVo : TableNameVo
    {
        /// <summary>
        /// Structural description of the columns of the table.
        /// </summary>
        public List<TableColumnVo> Columns { get; set; }
    }
}
