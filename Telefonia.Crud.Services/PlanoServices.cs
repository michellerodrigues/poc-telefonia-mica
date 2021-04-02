using System;
using Telefonia.Crud.Infra.Database.Repository;
using Telefonia.Crud.Services.Messages;

namespace Telefonia.Crud.Services
{
    public class PlanoServices : IPlanoServices
    {
        private readonly IPlanoTelefoniaRepository _planoTelefoniaRepository;

        public PlanoServices(IPlanoTelefoniaRepository planoTelefoniaRepository)
        {
            _planoTelefoniaRepository = planoTelefoniaRepository;
        }

        public ObterPlanoMessageResponse BuscarPlanoPorId(ObterPlanoMessageRequest request)
        {
            var retorno = _planoTelefoniaRepository.BuscarPlanoPorId(request.IdPlano, request.Ddd);

            var plano = new PlanoMessage()
            {
                FranquiaInternet = retorno.FranquiaInternet,
                Min = retorno.Min,
                Operadora = retorno.Operadora?.OperadoraNome,
                TipoPlano = retorno.Tipo?.Tipo,
                Valor = retorno.Valor
            };

            ObterPlanoMessageResponse response = new ObterPlanoMessageResponse()
            {
                Plano = plano
            };
            return response;
        }


        public ObterPlanoPorDDDMessageResponse ListarPlanosPorDDD(ObterPlanoPorDDDMessageRequest request)
        {
            throw new NotImplementedException();
        }

        public ObterPlanoPorOperadoraMessageResponse ObterPlanoPorOperadora(ObterPlanoPorOperadoraMessageRequest request)
        {
            throw new NotImplementedException();
        }

        public ObterPlanoPorTipoMessageResponse ObterPlanoPorTipo(ObterPlanoPorTipoMessageRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
