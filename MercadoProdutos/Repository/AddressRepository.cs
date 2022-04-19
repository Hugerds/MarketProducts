using MercadoProdutos.Interfaces;
using MercadoProdutos.Models;

namespace MercadoProdutos.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly MercadoProdutosContext _dbContext;
        public AddressRepository(MercadoProdutosContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Address CreateAddress(AddressViewModel AddressViewModel)
        {
            var address = new Address()
            {
                Id = new Guid(),
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Excluded = false,
                CityId = (Guid)AddressViewModel?.CityId,
                Complement = AddressViewModel.Complement,
                CityName = AddressViewModel.CityName,
                District = AddressViewModel.District,
                StateAbbreviation = AddressViewModel.StateAbbreviation,
                Number = AddressViewModel.Number,
                Street = AddressViewModel.Street,
            };
            _dbContext.Add(address);
            _dbContext.SaveChanges();
            return address;
        }
    }
}
