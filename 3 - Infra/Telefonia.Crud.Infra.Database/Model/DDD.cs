using System;
using System.Collections.Generic;

namespace Telefonia.Crud.Infra.Database.Model
{
    public class Ddd
    {
        public Ddd()
        {
            this.PlanosDisponiveis = new HashSet<Plano>();
        }
        public int DddId { get; set; }
        public int DDD { get; set; }

        public virtual ICollection<Plano> PlanosDisponiveis { get; set; }
    }
}
