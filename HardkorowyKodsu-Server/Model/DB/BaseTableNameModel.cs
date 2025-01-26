using HardkorowyKodsu_Server.Model.DB;

namespace HardkorowyKodsu_Server.Model.DB
{
    public abstract class BaseTableNameModel : BaseModel
    {
        /// <summary>
        /// Name of the view/table.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Foreign key to the schema the table/view belongs to.
        /// </summary>
        public int SchemaId { get; set; }
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
