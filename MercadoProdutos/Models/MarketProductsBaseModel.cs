namespace MercadoProdutos.Models
{
    public class MarketProductsBaseModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool Excluded { get; set; }
    }
}
