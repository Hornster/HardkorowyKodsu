namespace HardkorowyKodsu_Server.Model.DB
{
    /// <summary>
    /// Represents a data type in the database.
    /// The Id column is the user_type_id column from sys.types.
    /// </summary>
    public class DataTypeModel : BaseModel
    {
        public string Name { get; set; }
        public Int16 MaxLength { get; set; }
        public byte Precision { get; set; }
        public byte Scale { get; set; }
        public bool IsNullable { get; set; }
        public bool IsUserDefined { get; set; }
    }
}
