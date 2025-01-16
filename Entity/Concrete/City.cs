namespace Entity.Concrete
{
    public class City : BaseEntity
    {
        public string CityName { get; set; } 
        // Navigasyon özellikleri
        public List<District> Districts { get; set; } 
        public List<Address> Addresses { get; set; } }
    }
