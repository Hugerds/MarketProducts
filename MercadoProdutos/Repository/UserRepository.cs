using MercadoProdutos.Helpers;
using MercadoProdutos.Interfaces;
using MercadoProdutos.Models;
using MercadoProdutos.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;

namespace MercadoProdutos.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly MercadoProdutosContext _dbContext;
        private readonly SigningConfiguration _signingConfiguration;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserRepository([FromServices] SigningConfiguration signingConfiguration, MercadoProdutosContext dbContext, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _signingConfiguration = signingConfiguration;
            _dbContext = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(model.Username);
                if (user == null)
                    throw new Exception("Usuário ou senha incorretos");
                var response = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

                if (!response.Succeeded)
                    throw new Exception("Usuário ou senha incorretos");

                // return null if user not found
                if (user == null) return null;

                // authentication successful so generate jwt token
                var token = GenerateJwtToken(user);

                return new AuthenticateResponse(user, token);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<User> CreateUser(CreateUserViewModel UserViewModel)
        {
            try
            {
                var user = new User()
                {
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Name = UserViewModel.Name,
                    Email = UserViewModel.Email,
                    BirthDate = UserViewModel.BirthDate,
                    Document = UserViewModel.Document,
                    Id = new Guid(),
                    UserName = UserViewModel.UserName,
                };
                var response = await _userManager.CreateAsync(user, UserViewModel.Password);
                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string GenerateJwtToken(User user)
        {
            ClaimsIdentity identity = new(
                            new GenericIdentity(user.UserName.ToString(), "Login"),
                            new[] {
                        new Claim("ID", user.Id.ToString())
                            });
            var token = new JwtSecurityToken(
                         audience: "API",
                         expires: DateTime.Now.AddHours(3),
                         claims: identity.Claims,
                         signingCredentials: _signingConfiguration.SigningCredentials
                         );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
