namespace HardkorowyKodsu_Server.Model.VOs
{
    /// <summary>
    /// Viewobject containing the structure of a table column.
    /// </summary>
    public class TableColumnVo : BaseVo
    {

        /// <summary>
        /// The name of the column.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// The data type of the column. User defined or defaults to SystemType.
        /// </summary>
        public int UserTypeId { get; set; }
        /// <summary>
        /// The data type of the column. User defined or defaults to SystemType.
        /// </summary>
        public string DataType { get; set; } = string.Empty;
        /// <summary>
        /// The length of the column.
        /// </summary>
        public int MaxLength { get; set; }
        /// <summary>
        /// Is the column nullable?
        /// </summary>
        public bool IsNullable { get; set; }
        /// <summary>
        /// Is the column an identity column?
        /// </summary>
        public bool IsIdentity { get; set; }
        /// <summary>
        /// Precision of the column's value, where applicable.
        /// </summary>
        public byte Precision { get; set; }
        /// <summary>
        /// Scale of the column's value, where applicable.
        /// </summary>
        public byte Scale { get; set; }

        /// <summary>
        /// Id of the parent table/view this column belongs to.
        /// </summary>
        public int ParentObjectId { get; set; }

    }
}