namespace HardkorowyKodsu_Server.Model.VOs
{
    public class TableColumnVo : BaseVo
    {

        /// <summary>
        /// The name of the column.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// The data type of the column. System defined.
        /// </summary>
        public string SystemType { get; set; } = string.Empty;
        /// <summary>
        /// The data type of the column. User defined or defaults to SystemType.
        /// </summary>
        public string UserType { get; set; }
        /// <summary>
        /// The length of the column.
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// Is the column nullable?
        /// </summary>
        public bool IsNullable { get; set; }
        /// <summary>
        /// Is the column an identity column?
        /// </summary>
        public bool IsIdentity { get; set; }
        /// <summary>
        /// Is the column a primary key?
        /// </summary>
        public bool IsPrimaryKey { get; set; }
        /// <summary>
        /// The index of the column.
        /// </summary>
        public int OrdinalPosition { get; set; }
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
        public string DefaultValue { get; set; } = string.Empty;
        /// <summary>
        /// Id of the parent table/view this column belongs to.
        /// </summary>
        public int ParentObjectId { get; set; }

    }
}