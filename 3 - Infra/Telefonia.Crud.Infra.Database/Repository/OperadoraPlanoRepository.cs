using Telefonia.Crud.Infra.Database.Context;
using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public class OperadoraPlanoRepository : Repository<Operadora>, IOperadoraPlanoRepository
    {
        public OperadoraPlanoRepository(TelefoniaDatabaseContext context) : base(context)
        {
           
        }

        public Operadora BuscarOperadoraPlanoPorId(int idOperadora)
        {
            return GetById(idOperadora);
        }
    }
}
