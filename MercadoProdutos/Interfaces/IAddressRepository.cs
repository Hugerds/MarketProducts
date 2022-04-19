using MercadoProdutos.Models;
using MercadoProdutos.Repository;

namespace MercadoProdutos.Interfaces
{
    public interface IAddressRepository
    {
        Address CreateAddress(AddressViewModel AddressViewModel);
    }
}
