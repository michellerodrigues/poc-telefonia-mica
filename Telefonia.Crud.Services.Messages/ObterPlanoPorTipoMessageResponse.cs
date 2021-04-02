using System.Collections.Generic;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoPorTipoMessageResponse
    {
        public string TipoPlano { get; set; }
        public List<PlanoMessage> Planos { get; set; }
    }
}
