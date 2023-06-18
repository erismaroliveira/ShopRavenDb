namespace ShopRavenDb.Domain.Model
{
    public class Document
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
    }
}
