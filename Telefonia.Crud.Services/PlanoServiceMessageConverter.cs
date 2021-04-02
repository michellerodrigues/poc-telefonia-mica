using Telefonia.Crud.Infra.Database.Model;
using Telefonia.Crud.Services.Messages;

namespace Telefonia.Crud.Services
{
    public class PlanoServiceMessageConverter: IPlanoServiceMessageConverter
    {
        public PlanoMessage ConvertTo(Plano plano, int ddd)
        {
            return new PlanoMessage()
            {
                FranquiaInternet = plano.FranquiaInternet,
                Min = plano.Min,
                Operadora = plano.Operadora?.OperadoraNome,
                TipoPlano = plano.Tipo?.Tipo,
                Valor = plano.Valor,
                Ddd = ddd
            };
        }
    }
}
