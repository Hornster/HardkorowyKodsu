using Microsoft.Identity.Client;

namespace HardkorowyKodsu_Server.Model.DB
{
    /// <summary>
    /// Represents a column in a table.
    /// </summary>
    public class TableColumnModel : BaseModel
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
        /// The length of the column.
        /// </summary>
        public Int16 MaxLength { get; set; }
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
