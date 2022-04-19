using System.ComponentModel.DataAnnotations.Schema;

namespace MercadoProdutos.Models
{
    public class ProductMedia : MarketProductsBaseModel
    {
        [ForeignKey("Product")]
        public Guid ProductId;

        [ForeignKey("Media")]
        public Guid MediaId;
    }
}
