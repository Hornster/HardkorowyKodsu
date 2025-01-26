using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.Model
{
    /// <summary>
    /// Represents a table. Contains info about the columns as well.
    /// </summary>
    public class TableColumnsDataModel : TableNameModel
    {
        /// <summary>
        /// Structural description of the columns of the table.
        /// </summary>
        public List<TableColumnModel> Columns { get; set; }
    }
}
