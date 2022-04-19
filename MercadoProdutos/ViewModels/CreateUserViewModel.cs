using MercadoProdutos.Models;

namespace MercadoProdutos.ViewModels
{
    public class CreateUserViewModel : MarketProductsBaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
