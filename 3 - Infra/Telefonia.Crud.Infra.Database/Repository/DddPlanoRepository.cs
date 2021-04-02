using Microsoft.EntityFrameworkCore;
using System.Linq;
using Telefonia.Crud.Infra.Database.Context;
using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public class DddPlanoRepository : Repository<Ddd>, IDddPlanoRepository
    {
        public DddPlanoRepository(TelefoniaDatabaseContext context) : base(context)
        {
           
        }

        public Ddd BuscarDDDPorNumero(int ddd)
        {
            return _context.Ddds.Include(_=>_.PlanosDisponiveis).Where(_ => _.DDD == ddd).FirstOrDefault();
        }
    }
}
