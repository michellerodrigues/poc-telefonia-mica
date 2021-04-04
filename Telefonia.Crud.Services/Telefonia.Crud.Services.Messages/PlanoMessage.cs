using System;
using System.Collections.Generic;
using System.Text;

namespace Telefonia.Crud.Services.Messages
{
    public class PlanoMessage
    {
        public int Min { get; set; }
        public string FranquiaInternet { get; set; }
        public decimal Valor { get; set; }
        public string TipoPlano { get; set; }
        public string Operadora { get; set; }
        public int Ddd { get; set; }
    }
}
