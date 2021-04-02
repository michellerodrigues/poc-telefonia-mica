using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Telefonia.Crud.Services;
using Telefonia.Crud.Services.Messages;

namespace Telefonia.Crud.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanoController : ControllerBase
    {
        private readonly ILogger<PlanoController> _logger;
        private readonly IPlanoServices _planoServices;
        
        public PlanoController(ILogger<PlanoController> logger, IPlanoServices planoServices)
        {
            _logger = logger;
            _planoServices = planoServices;
        }
        /// <summary>
        /// ObterPlanoDDD
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("ObterPlanoDDD")]
        public ObterPlanoMessageResponse ObterPlanoDDD([FromQuery]ObterPlanoMessageRequest request)
        {
            return this._planoServices.BuscarPlanoPorId(request);
        }
    }
}
