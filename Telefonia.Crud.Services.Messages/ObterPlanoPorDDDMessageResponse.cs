using System.Collections.Generic;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoPorDDDMessageResponse
    {
        public int Ddd { get; set; }

        public List<PlanoMessage> PlanosDisponiveis { get; set; } = new List<PlanoMessage>();
    }
}
