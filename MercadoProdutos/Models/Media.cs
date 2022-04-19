using System.ComponentModel.DataAnnotations.Schema;

namespace MercadoProdutos.Models
{
    public class Media : MarketProductsBaseModel
    {
        public byte[] MediaBytes { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MediaCode { get; set; }
        public string MediaDescription { get; set; }
    }
}
