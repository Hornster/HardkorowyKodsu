namespace HardkorowyKodsu_Server.Model.VOs
{
    /// <summary>
    /// Database viewobject containing the structure of the database.
    /// </summary>
    public class DBStructureVo
    {
        /// <summary>
        /// Tables contained within the database.
        /// </summary>
        public List<TableNameVo> Tables { get; set; }
    }
}
