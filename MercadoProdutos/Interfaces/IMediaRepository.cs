using MercadoProdutos.Models;
using MercadoProdutos.ViewModels;

namespace MercadoProdutos.Interfaces
{
    public interface IMediaRepository
    {
        Media CreateMedia(CreateMediaViewModel mediaViewModel);
    }
}
