using Telefonia.Crud.Services.Messages;

namespace Telefonia.Crud.Services
{
    public interface IPlanoServices
    {
        ObterPlanoPorTipoMessageResponse ObterPlanoPorTipo(ObterPlanoPorTipoMessageRequest request);

        ObterPlanoPorOperadoraMessageResponse ObterPlanoPorOperadora(ObterPlanoPorOperadoraMessageRequest request);

        ObterPlanoMessageResponse BuscarPlanoPorId(ObterPlanoMessageRequest request);

        ObterPlanoPorDDDMessageResponse ListarPlanosPorDDD(ObterPlanoPorDDDMessageRequest request);
    }
}