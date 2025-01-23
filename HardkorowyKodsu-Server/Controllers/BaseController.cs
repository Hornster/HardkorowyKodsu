using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HardkorowyKodsu_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<T> : ControllerBase where T : class
    {
        protected readonly ILogger<T> _logger;
        public BaseController(ILogger<T> logger)
        {
            _logger = logger;
        }
    }
}
