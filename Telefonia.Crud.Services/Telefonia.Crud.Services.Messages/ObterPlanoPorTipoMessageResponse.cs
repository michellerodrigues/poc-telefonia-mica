using System.Collections.Generic;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoPorTipoMessageResponse
    {
        public string TipoPlano { get; set; }
        public List<PlanoMessage> PlanosDisponiveis { get; set; } = new List<PlanoMessage>();
    }
}
