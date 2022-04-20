using System.ComponentModel.DataAnnotations.Schema;

namespace MercadoProdutos.Models
{
    public class ProductMarket : MarketProductsBaseModel
    {
        public int Quantity { get; set; }
        public decimal Value { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        [ForeignKey("Market")]
        public Guid MarketId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Market Market { get; set; }
    }
}
