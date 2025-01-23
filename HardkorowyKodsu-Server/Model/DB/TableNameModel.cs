namespace HardkorowyKodsu_Server.Model.DTOs
{
    /// <summary>
    /// A lightweight model class used to retrieve the name and type of a table.
    /// </summary>
    public class TableNameModel
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
