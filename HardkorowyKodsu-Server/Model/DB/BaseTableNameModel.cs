using HardkorowyKodsu_Server.Model.DB;

namespace HardkorowyKodsu_Server.Model.DB
{
    public abstract class BaseTableNameModel : BaseModel
    {

        /// <summary>
        /// The name of the table.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// The type of the object. In this case table. Used by viewobjects.
        /// </summary>
        public string Type { get; set; } = string.Empty;
        /// <summary>
        /// The description of the type of the table.
        /// </summary>

        public string TypeDescription { get; set; } = string.Empty;
    }
}
