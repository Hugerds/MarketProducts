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
    public class ProductRepository : IProductRepository
    {
        protected readonly MercadoProdutosContext _dbContext;

        public ProductRepository(MercadoProdutosContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product CreateProduct(CreateProductViewModel productViewModel)
        {
            var product = new Product() { 
                Code = productViewModel.Code,
                Descricao = productViewModel.Descricao,
                Name = productViewModel.Name,
                QrCode = productViewModel.QrCode,
                Valor = productViewModel.Valor,
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Excluded = false
            };
            _dbContext.Add(product);
            _dbContext.SaveChanges();
            return product;
        }
    }
}
