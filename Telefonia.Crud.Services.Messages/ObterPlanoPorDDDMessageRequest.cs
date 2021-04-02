using System.Collections.Generic;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoPorDDDMessageRequest
    {
        public int Ddd { get; set; }
        public List<PlanoMessage> Planos { get; set; }
    }
}
