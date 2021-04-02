using System.Collections.Generic;
using Telefonia.Crud.Infra.Database.Context;
using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public class PlanoTelefoniaRepository : Repository<Plano>, IPlanoTelefoniaRepository
    {
        public PlanoTelefoniaRepository(TelefoniaDatabaseContext context) : base(context)
        {

        }

        public Plano BuscarPlanoPorId(string idPlano, int ddd)
        {
            throw new System.NotImplementedException();
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
