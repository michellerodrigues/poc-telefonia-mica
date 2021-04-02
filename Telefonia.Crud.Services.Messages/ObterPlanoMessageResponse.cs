using System.Collections.Generic;

namespace Telefonia.Crud.Services.Messages
{
    public class ObterPlanoMessageResponse
    {
        public int IdPlano { get; set; }
        public int DDD { get; set; }
        public PlanoMessage Plano { get; set; }
    }
}
