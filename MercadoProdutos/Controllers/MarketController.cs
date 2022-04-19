using MercadoProdutos.Models;
using MercadoProdutos.Repository;
using MercadoProdutos.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MercadoProdutos.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class MarketController : ControllerBase
    {
        private readonly IMarketRepository _marketRepository;
        private readonly UserManager<User> _userManager;
        public MarketController(IMarketRepository marketRepository, UserManager<User> userManager)
        {
            _marketRepository = marketRepository;
            _userManager = userManager;
        }

        [HttpPost]
        public IActionResult CreateMarket([FromBody] MarketViewModel MarketViewModel)
        {
            var user = _userManager.Users.FirstOrDefault(u => u.NormalizedUserName == User.Identity.Name.ToUpper());
            var response = _marketRepository.CreateMarket(MarketViewModel, user.Id);
            if (response == null) return BadRequest("Mercado não foi criado");
            return Ok(response);
        }
    }
}
