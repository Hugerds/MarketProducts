using MercadoProdutos.Models;

namespace MercadoProdutos
{
    public class Product : MarketProductsBaseModel
    {
        public string Name { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Code { get; set; }
        public string QrCode { get; set; }
    }
   }
