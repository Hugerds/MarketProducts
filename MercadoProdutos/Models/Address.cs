using System.ComponentModel.DataAnnotations.Schema;

namespace MercadoProdutos.Models
{
    public class Address : MarketProductsBaseModel
    {
        [ForeignKey("City")]
        public Guid CityId { get; set; }

        public string Street { get; set; }
        public string District { get; set; }
        public string StateAbbreviation { get; set; }
        public string CityName { get; set; }
        public string Complement { get; set; }
        public int Number { get; set; }

        public virtual City City { get; set; }
    }
}
