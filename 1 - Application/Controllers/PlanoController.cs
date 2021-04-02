using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Telefonia.Crud.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanoController : ControllerBase
    {
        private readonly ILogger<PlanoController> _logger;

        public PlanoController(ILogger<PlanoController> logger)
        {
            _logger = logger;
        }          
    }
}
