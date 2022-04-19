using MercadoProdutos.Models;

namespace MercadoProdutos.Interfaces
{
    public interface IStateRepository
    {
        State GetStateByAbbreviation(string StateAbbreviation);
    }
}
