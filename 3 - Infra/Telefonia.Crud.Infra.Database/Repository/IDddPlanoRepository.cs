using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public interface IDddPlanoRepository
    {
        public Ddd BuscarDDDPorNumero(int ddd);
    }
}
