using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.Model
{
    public class DbStructureModel
    {
        /// <summary>
        /// Tables contained within the database.
        /// </summary>
        public List<TableNameModel> Tables { get; set; }
    }
}
