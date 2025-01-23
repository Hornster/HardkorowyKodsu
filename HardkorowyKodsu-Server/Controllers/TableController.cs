using HardkorowyKodsu_Server.Model.VOs;
using HardkorowyKodsu_Server.Repos.Interface;
using HardkorowyKodsu_Server.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HardkorowyKodsu_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : BaseController<TableController>
    {
        protected readonly IDbStructureService _dbStructureService;
        public TableController(ILogger<TableController> logger, IDbStructureService dbStructureService) : base(logger)
        {
            _dbStructureService = dbStructureService;
        }

        public TableDataVo Get(int tableId)
        {
            var tableData = _dbStructureService.GetTableData(tableId);
            return tableData;
        }
    }
}
