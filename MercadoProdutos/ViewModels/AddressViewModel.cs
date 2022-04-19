namespace MercadoProdutos.Repository
{
    public class AddressViewModel
    {
        public string Street { get; set; }
        public string District { get; set; }
        public string StateAbbreviation { get; set; }
        public string CityName { get; set; }
        public string Complement { get; set; }
        public int Number { get; set; }
        public Guid? CityId { get; set; }
    }
}
