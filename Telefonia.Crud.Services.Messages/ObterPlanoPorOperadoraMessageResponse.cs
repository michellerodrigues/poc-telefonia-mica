using System.Collections.Generic;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoPorOperadoraMessageResponse
    {
        public string Operadora { get; set; }
        public List<PlanoMessage> Planos { get; set; }
    }
}
