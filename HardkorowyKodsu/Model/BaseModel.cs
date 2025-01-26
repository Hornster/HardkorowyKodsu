using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardkorowyKodsu.Model
{
    /// <summary>
    /// Base model for all models that require an ID field.
    /// </summary>
    public class BaseModel
    {
        public int Id { get; set; }
    }
}
