using MercadoProdutos.Interfaces;
using MercadoProdutos.Models;

namespace MercadoProdutos.Repository
{
    public class ProductMarketRepository : IProductMarketRepository
    {
        private readonly MercadoProdutosContext _dbContext;
        public ProductMarketRepository(MercadoProdutosContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool CreateProductMarket(List<ProductMarket> ProductMarkets)
        {
            try
            {
                _dbContext.ProductMarket.AddRange(ProductMarkets);
                _dbContext.SaveChanges();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
