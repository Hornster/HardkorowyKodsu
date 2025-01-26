namespace HardkorowyKodsu_Server.Model.DB
{
    /// <summary>
    /// A short model for retrieveing partial data about database schemas.
    /// </summary>
    public class SchemaShortModel : BaseModel
    {
        /// <summary>
        /// Name of the schema.
        /// </summary>
        public string Name { get; set; }
    }
}
