using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.Model
{
    public class TableDetailsDataModel : TableNameModel
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
