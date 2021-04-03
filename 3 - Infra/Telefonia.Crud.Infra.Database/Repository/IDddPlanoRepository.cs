using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public interface IDddPlanoRepository
    {
        Ddd BuscarDDDPorNumero(int ddd);
        void AtualizarDDD(Ddd ddd);
    }
}
