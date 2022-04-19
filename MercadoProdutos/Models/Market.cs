using System.ComponentModel.DataAnnotations.Schema;

namespace MercadoProdutos.Models
{
    public class Market : MarketProductsBaseModel
    {
        [ForeignKey("Address")]
        public Guid AddressId { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Document { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarketCode { get; set; }
    }
}
