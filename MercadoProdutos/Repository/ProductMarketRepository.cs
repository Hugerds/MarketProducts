using MercadoProdutos.Interfaces;
using MercadoProdutos.Models;
using MercadoProdutos.ViewModels;

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

        public IEnumerable<CreateProductViewModel> GetProductMarketByMarketCode(int MarketCode)
        {
            try
            {
                var market = _dbContext.Market.FirstOrDefault(x => x.MarketCode == MarketCode);
                if (market == null) throw new Exception("Mercado não encontrado");
                var listProducts = (from p in _dbContext.Product.Where(p => !p.Excluded)
                                    join pm in _dbContext.ProductMarket.Where(p => !p.Excluded) on p.Id equals pm.ProductId
                                    where pm.MarketId == market.Id
                                    select new CreateProductViewModel()
                                    {
                                        Id = p.Id,
                                        Code = p.Code,
                                        Value = pm.Value,
                                        Description = p.Description,
                                        Name = p.Name,
                                        QrCode = p.QrCode,
                                    }).ToList();
                if (listProducts == null) throw new Exception();
                return listProducts;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<CreateProductViewModel> GetProductMarketByMarketId(Guid MarketId)
        {
            try
            {
                var listProducts = (from p in  _dbContext.Product.Where(p => !p.Excluded)
                                   join pm in _dbContext.ProductMarket.Where(p => !p.Excluded) on p.Id equals pm.ProductId
                                   where pm.MarketId == MarketId
                                    select new CreateProductViewModel()
                                    {
                                        Id = p.Id,
                                        Code = p.Code,
                                        Value = pm.Value,
                                        Description = p.Description,
                                        Name = p.Name,
                                        QrCode = p.QrCode,
                                    }).ToList();
                if (listProducts == null) throw new Exception();
                return listProducts;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
