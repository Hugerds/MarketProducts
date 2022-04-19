using MercadoProdutos.Models;
using MercadoProdutos.ViewModels;

namespace MercadoProdutos.Interfaces
{
    public interface IUserRepository
    {
        Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
        Task<User> CreateUser(CreateUserViewModel UserViewModel);
    }
}
