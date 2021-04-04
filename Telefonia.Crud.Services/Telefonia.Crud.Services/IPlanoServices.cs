using Telefonia.Crud.Services.Messages;

namespace Telefonia.Crud.Services
{
    public interface IPlanoServices
    {
        ObterPlanoPorTipoMessageResponse ObterPlanoPorTipo(ObterPlanoPorTipoMessageRequest request);

        ObterPlanoPorOperadoraMessageResponse ObterPlanoPorOperadora(ObterPlanoPorOperadoraMessageRequest request);

        ObterPlanoMessageResponse BuscarPlanoPorId(ObterPlanoMessageRequest request);

        ObterPlanoPorDDDMessageResponse ListarPlanosPorDDD(ObterPlanoPorDDDMessageRequest request);

        void CadastrarPlano(CadastrarPlanoMessageRequest request);
        void DeletarPlano(DeletarPlanoMessageRequest request);
        void AtualizarPlano(AtualizarPlanoMessageRequest request);
    }
}