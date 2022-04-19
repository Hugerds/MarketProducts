using MercadoProdutos.Helpers;
using MercadoProdutos.Interfaces;
using MercadoProdutos.Models;
using MercadoProdutos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace MercadoProdutos.Repository
{
    public class MediaRepository : IMediaRepository
    {
        protected readonly MercadoProdutosContext _dbContext;

        public MediaRepository(MercadoProdutosContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Media CreateMedia(CreateMediaViewModel mediaViewModel)
        {
            byte[] bytes = Convert.FromBase64String(mediaViewModel.MediaBinarized);
            var media = new Media() { 
                MediaBytes = bytes,
                MediaDescription = mediaViewModel.MediaDescription,
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Excluded = false
            };
            _dbContext.Add(media);
            _dbContext.SaveChanges();
            return media;
        }
    }
}
