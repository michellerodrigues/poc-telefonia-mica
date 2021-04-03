using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public interface ITipoPlanoRepository
    {
        TipoPlano BuscarTipoPlanoPorId(int idTipoPlano);
        TipoPlano BuscarTipoPlanoPorNome(string tipoPlano);
    }
}
