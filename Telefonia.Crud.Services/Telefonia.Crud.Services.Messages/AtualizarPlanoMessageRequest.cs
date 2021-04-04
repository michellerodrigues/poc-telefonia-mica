using Telefonia.Crud.Services.Messages;

namespace Telefonia.Crud.Services
{
    public class AtualizarPlanoMessageRequest
    {
        public int IdPlano { get; set; }
        public int Ddd { get; set; }
        public PlanoMessage PlanoUpdate { get; set; }
    }
}