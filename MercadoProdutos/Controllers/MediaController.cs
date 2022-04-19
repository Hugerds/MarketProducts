using MercadoProdutos.Interfaces;
using MercadoProdutos.Repository;
using MercadoProdutos.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MercadoProdutos.Controllers
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class MediaController : ControllerBase
    {
        private readonly IMediaRepository _mediaRepository;

        public MediaController(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] CreateMediaViewModel mediaViewModel)
        {
            var media = _mediaRepository.CreateMedia(mediaViewModel);
            return Ok(media);
        }
    }
}
