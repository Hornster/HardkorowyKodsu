namespace HardkorowyKodsu_Server.Model.VOs
{
    /// <summary>
    /// A thin viewobject containing the name and type of a table, used to retrieve structure of table its instance refers to.
    /// </summary>
    public class TableNameVo : BaseVo
    {
        /// <summary>
        /// The name of the table.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// The type of the table. View? Regular table?
        /// </summary>
        public string Type { get; set; } = string.Empty;
    }
}
