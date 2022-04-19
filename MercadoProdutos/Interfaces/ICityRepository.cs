using MercadoProdutos.Models;

namespace MercadoProdutos.Interfaces
{
    public interface ICityRepository
    {
        public City GetCityByName(string CityName, Guid StateId);
    }
}
