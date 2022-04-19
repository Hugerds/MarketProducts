using MercadoProdutos.Models;

namespace MercadoProdutos.Interfaces
{
    public interface IProductMarketRepository
    {
        bool CreateProductMarket(List<ProductMarket> ProductMarkets);
    }
}
