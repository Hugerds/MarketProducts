using MercadoProdutos.Models;

namespace MercadoProdutos
{
    public class Product : MarketProductsBaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Value { get; set; }
        public string Code { get; set; }
        public string QrCode { get; set; }
    }
   }
