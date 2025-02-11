﻿namespace HardkorowyKodsu_Server.Model.VOs
{
    /// <summary>
    /// A thin viewobject containing the name and type of a table or view, used to retrieve structure of table or view its instance refers to.
    /// </summary>
    public class TableNameVo : BaseVo
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
