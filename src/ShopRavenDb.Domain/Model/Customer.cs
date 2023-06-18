namespace ShopRavenDb.Domain.Model
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public string CPF { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
