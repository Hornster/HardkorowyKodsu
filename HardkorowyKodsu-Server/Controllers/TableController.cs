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
        [HttpGet]
        public TableDetailsDataVo Get(int tableId, char tableType)
        {
            var getTableDataTask = _dbStructureService.GetTableOrViewDetailsAsync(tableId, tableType);
            getTableDataTask.Wait();

            var tableData = getTableDataTask.Result;
            return tableData;
        }
        [HttpGet]
        [Route("columns")]
        public TableColumnsDataVo GetColumns(int tableId)
        {
            var getStructureTask = _dbStructureService.GetTableColumnsDataAsync(tableId);
            getStructureTask.Wait();
            var structure = getStructureTask.Result;
            return structure;
        }
        //[HttpGet]
        //[Route("column")]
        //public TableColumnVo GetColumn(int tableId, int columnId)
        //{
        //    var getStructureTask = _dbStructureService.GetColumnDataAsync(tableId, columnId);
        //    getStructureTask.Wait();
        //    var structure = getStructureTask.Result;
        //    return structure;
        //}
    }
}
