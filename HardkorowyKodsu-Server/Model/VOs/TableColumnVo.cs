namespace HardkorowyKodsu_Server.Model.VOs
{
    public class TableColumnVo : BaseVo
    {

        /// <summary>
        /// The name of the column.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// The data type of the column.
        /// </summary>
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// The length of the column.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// Is the column nullable?
        /// </summary>
        public bool Nullable { get; set; }
        /// <summary>
        /// Is the column a primary key?
        /// </summary>
        public bool PrimaryKey { get; set; }
        /// <summary>
        /// Is the column an autoincrement?
        /// </summary>
        public bool AutoIncrement { get; set; }
        /// <summary>
        /// Is the column a foreign key?
        /// </summary>
        public bool IsForeignKey { get; set; }
        /// <summary>
        /// The table that the foreign key references.
        /// </summary>
        public string ForeignKeyTable { get; set; } = string.Empty;

    }
}