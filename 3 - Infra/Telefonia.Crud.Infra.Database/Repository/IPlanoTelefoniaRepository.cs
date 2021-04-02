using System.Collections.Generic;
using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public interface IPlanoTelefoniaRepository
    {
        List<Plano> BuscarPlanoPorTipo(TipoPlano tipo, int ddd);

        List<Plano> BuscarPlanoPorOperadora(Operadora operadora, int ddd);

        Plano BuscarPlanoPorId(string idPlano, int ddd);

        List<Plano> ListarPlanosPorDDD(int ddd);
    }
}
