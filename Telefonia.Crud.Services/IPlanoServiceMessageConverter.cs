using Telefonia.Crud.Infra.Database.Model;
using Telefonia.Crud.Services.Messages;

namespace Telefonia.Crud.Services
{
    public interface IPlanoServiceMessageConverter
    {
        public PlanoMessage ConvertTo(Plano plano, int ddd);
    }
}