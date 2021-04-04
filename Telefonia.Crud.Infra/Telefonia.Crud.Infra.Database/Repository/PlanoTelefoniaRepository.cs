using Microsoft.EntityFrameworkCore;
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

        public void IncluirPlano(Plano plano)
        {
            Create(plano);
        }

        public void DeletarPlano(int planoId)
        {
            var plano = _context.Planos.Where(_=>_.PlanoId == planoId).FirstOrDefault();
            if(plano!=null)
                Remove(plano);

        }

        public void AtualizarPlano(Plano planoFind)
        {
            Update(planoFind);
        }


        public Plano BuscarPlanoPorId(int idPlano, Ddd ddd)
        {
            return _context.Planos.Include(_ => _.Operadora).Include(_ => _.Tipo).Where(_ => _.PlanoId == idPlano && _.DddsAtendidos.Contains(ddd)).FirstOrDefault();
        }

        public List<Plano> BuscarPlanoPorOperadora(Operadora operadora, Ddd ddd)
        {
            return _context.Planos.Include(_ => _.Operadora).Include(_ => _.Tipo).Where(_ => _.Operadora == operadora && _.DddsAtendidos.Contains(ddd)).ToList();
        }

        public List<Plano> BuscarPlanoPorTipo(TipoPlano tipo, Ddd ddd)
        {
            return _context.Planos.Include(_ => _.Tipo).Include(_ => _.Operadora).Where(_ => _.Tipo.Id == tipo.Id && _.DddsAtendidos.Contains(ddd)).ToList();
        }

        public List<Plano> ListarPlanosPorDDD(Ddd ddd)
        {
            return _context.Planos.Include(_ => _.Operadora).Include(_ => _.Tipo).Where(_ => _.DddsAtendidos.Contains(ddd)).ToList();
        }
    }
}
