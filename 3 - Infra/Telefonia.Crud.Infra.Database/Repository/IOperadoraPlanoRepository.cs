using Telefonia.Crud.Infra.Database.Model;

namespace Telefonia.Crud.Infra.Database.Repository
{
    public interface IOperadoraPlanoRepository
    {
        Operadora BuscarOperadoraPlanoPorId(int idOperadora);
    }
}