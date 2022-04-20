namespace MercadoProdutos.ViewModels
{
    public class CreateProductViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public string Code { get; set; }
        public string QrCode { get; set; }
    }
}
