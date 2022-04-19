using System.ComponentModel.DataAnnotations.Schema;

namespace MercadoProdutos.Models
{
    public class City : MarketProductsBaseModel
    {
        [ForeignKey("State")]
        public Guid StateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual State State { get; set; }
    }
}
