using System.Collections.Generic;
using System.Linq;
using Telefonia.Crud.Infra.Database.Context;
using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public class PlanoTelefoniaRepository : Repository<Plano>, IPlanoTelefoniaRepository
    {
        public PlanoTelefoniaRepository(TelefoniaDatabaseContext context) : base(context)
        {

        }

        public Plano BuscarPlanoPorId(int idPlano, int dddId)
        {
            var ddd = _context.Ddds.Where(_ => _.DddId == dddId).FirstOrDefault();
            return _context.Planos.Where(_ => _.PlanoId == idPlano && _.DddsAtendidos.Contains(ddd)).FirstOrDefault();
        }

        public List<Plano> BuscarPlanoPorOperadora(Operadora operadora, int ddd)
        {
            throw new System.NotImplementedException();
        }

        public List<Plano> BuscarPlanoPorTipo(TipoPlano tipo, int ddd)
        {
            throw new System.NotImplementedException();
        }

        public List<Plano> ListarPlanosPorDDD(int ddd)
        {
            throw new System.NotImplementedException();
        }
    }
}
