using MercadoProdutos.Interfaces;
using MercadoProdutos.Models;

namespace MercadoProdutos.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly MercadoProdutosContext _dbContext;
        public CityRepository(MercadoProdutosContext dbContext)
        {
            _dbContext = dbContext;
        }

        public City GetCityByName(string CityName, Guid StateId)
        {
            var city = _dbContext.City.FirstOrDefault(c => c.Name.ToLower() == CityName.ToLower() && c.StateId == StateId);
            if (city == null)
            {
                city = new City()
                {
                    Id = Guid.NewGuid(),
                    StateId = StateId,
                    Description = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Name = CityName,
                    Excluded = false,
                };
                _dbContext.City.Add(city);
                _dbContext.SaveChanges();
            }
            return city;
        }
    }
}
