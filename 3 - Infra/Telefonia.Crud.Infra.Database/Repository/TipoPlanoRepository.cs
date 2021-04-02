using Telefonia.Crud.Infra.Database.Context;
using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public class TipoPlanoRepository : Repository<TipoPlano>, ITipoPlanoRepository
    {
        public TipoPlanoRepository(TelefoniaDatabaseContext context) : base(context)
        {
           
        }

        public TipoPlano BuscarTipoPlanoPorId(int idTipoPlano)
        {
            return GetById(idTipoPlano);
        }
    }
}
