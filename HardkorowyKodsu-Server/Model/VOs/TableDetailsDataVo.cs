namespace HardkorowyKodsu_Server.Model.VOs
{
    /// <summary>
    /// View object describing the details of a table.
    /// </summary>
    public class TableDetailsDataVo : TableNameVo
    {
        /// <summary>
        /// Time of creation of the table/view.
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Last modification time of the table/view.
        /// </summary>
        public DateTime ModifyDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsSchemaPublished { get; set; }
    }
}
