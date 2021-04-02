using System;
using System.Collections.Generic;

namespace Telefonia.Crud.Infra.Database.Model
{
    public class Plano
    {
        public Plano()
        {
            this.DddsAtendidos = new HashSet<Ddd>();
        }

        public int PlanoId { get; set; }
        public int Min { get; set; }
        public string FranquiaInternet { get; set; }
        public decimal Valor { get; set; }
        public TipoPlano Tipo { get; set; }
        public Operadora Operadora { get; set; }
        public virtual ICollection<Ddd> DddsAtendidos { get; set; }
    }
}
