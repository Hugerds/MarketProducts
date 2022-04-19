using MercadoProdutos.Models;
using MercadoProdutos.ViewModels;

namespace MercadoProdutos.Interfaces
{
    public interface IProductRepository
    {
        Product CreateProduct(CreateProductViewModel productViewModel);
    }
}
