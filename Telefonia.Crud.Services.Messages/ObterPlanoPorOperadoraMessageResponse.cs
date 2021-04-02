using System.Collections.Generic;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoPorOperadoraMessageResponse
    {
        public string Operadora { get; set; }
        public List<PlanoMessage> PlanosDisponiveis { get; set; } = new List<PlanoMessage>();
    }
}
