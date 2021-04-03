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
        /// CriarPlano
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("CriarPlano")]
        public void CriarPlano([FromBody]CadastrarPlanoMessageRequest request)
        {
            this._planoServices.CadastrarPlano(request);
        }


        /// <summary>
        /// DeletarPlano
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete("DeletarPlano")]
        public void DeletarPlano([FromBody]DeletarPlanoMessageRequest request)
        {
            this._planoServices.DeletarPlano(request);
        }

        /// <summary>
        /// ObterPlanoDDD
        /// Ex: ddd  = 11,21,24,41 
        /// Ex: PlanoID: 1,2,3...
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
        /// Ex: ddd  = 11,21,24,41 
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
        /// Ex: ddd  = 11,21,24,41 
        /// Ex Operadora: 1 (vivo), 2 (claro), 3 (tim)
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
        /// Ex: ddd  = 11,21,24,41 
        /// Ex: Tipo Plano 1 (controle), 2 (pós-pago), 3 (pré-pago)
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
