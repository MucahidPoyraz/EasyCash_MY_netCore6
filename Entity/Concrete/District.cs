namespace Entity.Concrete
{
    public class District : BaseEntity
    {
        public string Name { get; set; }
        public Guid CityId { get; set; } 
        // Navigasyon özellikleri
        public City City { get; set; }
        public List<Address> Addresses { get; set; } }
    }
