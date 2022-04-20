using MercadoProdutos.Interfaces;
using MercadoProdutos.Models;
using MercadoProdutos.Repository;
using MercadoProdutos.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MercadoProdutos.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class ProductMarketController : ControllerBase
    {
        private readonly IProductMarketRepository _productMarketRepository;
        public ProductMarketController(IProductMarketRepository productMarketRepository)
        {
            _productMarketRepository = productMarketRepository;
        }

        [HttpPost]
        public IActionResult CreateProductMarket([FromBody] List<ProductMarket> ProductMarkets)
        {
            var response = _productMarketRepository.CreateProductMarket(ProductMarkets);
            if (!response) return BadRequest();
            return Ok();
        }

        [HttpGet]
        [Route("GetProductMarketByMarketId")]
        public IActionResult GetProductMarketByMarketId(Guid MarketId)
        {
            var response = _productMarketRepository.GetProductMarketByMarketId(MarketId);
            if (response == null) return BadRequest();
            return Ok(response);
        }
        [HttpGet]
        [Route("GetProductMarketByMarketCode")]
        public IActionResult GetProductMarketByMarketCode(int MarketCode)
        {
            var response = _productMarketRepository.GetProductMarketByMarketCode(MarketCode);
            if (response == null) return BadRequest();
            return Ok(response);
        }
    }
}
