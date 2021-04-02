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

        /// <summary>
        /// ListarPlanosPorDDD
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("ListarPlanosPorDDD")]
        public ObterPlanoPorDDDMessageResponse ListarPlanosPorDDD([FromQuery]ObterPlanoPorDDDMessageRequest request)
        {
            return this._planoServices.ListarPlanosPorDDD(request);
        }

        /// <summary>
        /// ObterPlanoPorOperadora
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("ObterPlanoPorOperadora")]
        public ObterPlanoPorOperadoraMessageResponse ObterPlanoPorOperadora([FromQuery]ObterPlanoPorOperadoraMessageRequest request)
        {
            return this._planoServices.ObterPlanoPorOperadora(request);
        }

        /// <summary>
        /// ObterPlanoPorTipo
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("ObterPlanoPorTipo")]
        public ObterPlanoPorTipoMessageResponse ObterPlanoPorTipo([FromQuery]ObterPlanoPorTipoMessageRequest request)
        {
            return this._planoServices.ObterPlanoPorTipo(request);
        }
    }
}
