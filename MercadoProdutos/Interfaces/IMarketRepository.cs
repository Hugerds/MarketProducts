using MercadoProdutos.Models;
using MercadoProdutos.ViewModels;

namespace MercadoProdutos.Repository
{
    public interface IMarketRepository
    {
        Market CreateMarket(MarketViewModel MarketViewModel, Guid UserId);
    }
}
