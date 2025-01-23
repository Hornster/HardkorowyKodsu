﻿using HardkorowyKodsu_Server.Model.VOs;

namespace HardkorowyKodsu_Server.Model.DTOs
{
    /// <summary>
    /// Represents a table in the database.
    /// </summary>
    public class TableDataModel : TableNameModel
    {
        /// <summary>
        /// Structural description of the columns of the table.
        /// </summary>
        public List<TableColumnVo> Columns { get; set; }
    }
}
