using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.Model
{
    /// <summary>
    /// Represents a column in a table or view.
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
        public string DataType { get; set; } = string.Empty;
        /// <summary>
        /// The length of the column.
        /// </summary>
        public int MaxLength { get; set; }
        /// <summary>
        /// Precision of the column's value, where applicable.
        /// </summary>
        public int Precision { get; set; }
        /// <summary>
        /// Scale of the column's value, where applicable.
        /// </summary>
        public int Scale { get; set; }
        /// <summary>
        /// Is the column nullable?
        /// </summary>
        public bool IsNullable { get; set; }
        /// <summary>
        /// Is the column an identity column?
        /// </summary>
        public bool IsIdentity { get; set; }
        /// <summary>
        /// Id of the parent table/view this column belongs to.
        /// </summary>
        public int ParentObjectId { get; set; }
    }
}
