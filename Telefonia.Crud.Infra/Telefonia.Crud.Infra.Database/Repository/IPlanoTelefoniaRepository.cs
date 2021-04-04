using System.Collections.Generic;
using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public interface IPlanoTelefoniaRepository
    {
        List<Plano> BuscarPlanoPorTipo(TipoPlano tipo, Ddd ddd);

        List<Plano> BuscarPlanoPorOperadora(Operadora operadora, Ddd ddd);

        Plano BuscarPlanoPorId(int idPlano, Ddd ddd);

        List<Plano> ListarPlanosPorDDD(Ddd ddd);

        void IncluirPlano(Plano plano);
        void DeletarPlano(int idPlano);
        void AtualizarPlano(Plano planoFind);
    }
}
