using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public interface ITipoPlanoRepository
    {
        public TipoPlano BuscarTipoPlanoPorId(int idTipoPlano);
    }
}
