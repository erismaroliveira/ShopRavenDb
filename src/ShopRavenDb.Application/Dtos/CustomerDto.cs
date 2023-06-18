namespace ShopRavenDb.Application.Dtos
{
    public class CustomerDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public AddressDto Address { get; set; }
        public string CPF { get; set; } = string.Empty;
    }
}
