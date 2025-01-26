using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.Model
{
    /// <summary>
     /// A thin object containing the name and type of a table.
     /// </summary>
    public class TableNameModel : BaseModel
    {

        /// <summary>
        /// The id of the schema the table belongs to.
        /// </summary>
        public int SchemaId { get; set; }
        /// <summary>
        /// The name of the schema the table belongs to.
        /// </summary>
        public string SchemaName { get; set; } = string.Empty;
        /// <summary>
        /// The name of the table.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// The type of the table. View? Regular table?
        /// </summary>
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// The description of the type of the table.
        /// </summary>

        public string TypeDescription { get; set; } = string.Empty;
    }
}
