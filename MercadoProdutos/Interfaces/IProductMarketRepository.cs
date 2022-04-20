using MercadoProdutos.Models;
using MercadoProdutos.ViewModels;

namespace MercadoProdutos.Interfaces
{
    public interface IProductMarketRepository
    {
        bool CreateProductMarket(List<ProductMarket> ProductMarkets);
        IEnumerable<CreateProductViewModel> GetProductMarketByMarketId(Guid MarketId);
        IEnumerable<CreateProductViewModel> GetProductMarketByMarketCode(int MarketCode);
    }
}
