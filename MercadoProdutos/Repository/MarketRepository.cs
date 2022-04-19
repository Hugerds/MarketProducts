using MercadoProdutos.Interfaces;
using MercadoProdutos.Models;
using MercadoProdutos.Repository;
using System.Text.RegularExpressions;

namespace MercadoProdutos.ViewModels
{
    public class MarketRepository : IMarketRepository
    {
        private readonly MercadoProdutosContext _dbContext;
        private readonly IStateRepository _stateRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IAddressRepository _addressRepository;
        public MarketRepository(MercadoProdutosContext dbContext, IStateRepository stateRepository, ICityRepository cityRepository, IAddressRepository addressRepository)
        {
            _dbContext = dbContext;
            _stateRepository = stateRepository;
            _cityRepository = cityRepository;
            _addressRepository = addressRepository;
        }

        public Market CreateMarket(MarketViewModel MarketViewModel, Guid UserId)
        {
            try
            {
                //Will search state by abbreviation, if not found, create it
                var state = _stateRepository.GetStateByAbbreviation(MarketViewModel.Address.StateAbbreviation);
                //Will search city by name to lower case, if not found, creat it and the relacioment with stateId
                var city = _cityRepository.GetCityByName(MarketViewModel.Address.CityName, state.Id);
                //Create address
                MarketViewModel.Address.CityId = city.Id;
                var address = _addressRepository.CreateAddress(MarketViewModel.Address);
                //Create object Market and return it and search market by document, if found update it
                var market = GetMarketByDocument(MarketViewModel.Document);
                if(market == null)
                {
                    market = new Market()
                    {
                        Id = new Guid(),
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        Excluded = false,
                        Description = MarketViewModel.Description,
                        Document = MarketViewModel.Document,
                        Name = MarketViewModel.Name,
                        AddressId = address.Id,
                        UserId = UserId,
                    };
                    _dbContext.Add(market);
                } else
                {
                    market.AddressId = address.Id;
                    market.Description = MarketViewModel.Description;
                    market.UpdatedDate = DateTime.Now;
                    market.Name = MarketViewModel.Name;
                    _dbContext.Update(market);
                }
                _dbContext.SaveChanges();
                return market;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private Market GetMarketByDocument(string Document)
        {
            try
            {
                Document = Regex.Replace(Document, "[^0-9]", "");
                var market = _dbContext.Market.FirstOrDefault(m => m.Document.Equals(Document));
                if (market == null) throw new Exception();
                return market;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
