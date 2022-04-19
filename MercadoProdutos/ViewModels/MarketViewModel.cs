using MercadoProdutos.Repository;

namespace MercadoProdutos.ViewModels
{
    public class MarketViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Document { get; set; }
        public AddressViewModel Address { get; set; }

    }
}
