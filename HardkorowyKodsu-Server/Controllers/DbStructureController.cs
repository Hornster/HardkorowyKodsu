using HardkorowyKodsu_Server.Model.VOs;
using HardkorowyKodsu_Server.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HardkorowyKodsu_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbStructureController : BaseController<DbStructureController>
    {
        protected readonly IDbStructureService _dbStructureService;
        public DbStructureController(ILogger<DbStructureController> logger, IDbStructureService dbStructureService) : base(logger)
        {
            _dbStructureService = dbStructureService;
        }
        [HttpGet]
        public DBStructureVo Get()
        {
            var result = _dbStructureService.GetStructure();
            return result;
        }
    }
}
