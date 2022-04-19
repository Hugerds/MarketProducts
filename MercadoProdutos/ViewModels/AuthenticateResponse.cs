using MercadoProdutos.Models;

namespace MercadoProdutos.ViewModels
{
    public class AuthenticateResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            Name = user.Name;
            Login = user.UserName;
            Token = token;
        }
    }
}
