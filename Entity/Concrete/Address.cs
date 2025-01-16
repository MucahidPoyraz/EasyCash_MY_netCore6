using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public Guid CityId { get; set; }
        public City City { get; set; }
        public Guid DistrictId { get; set; }
        public District District { get; set; } 
        // Navigasyon özellikleri
        public List<AppUser> AppUsers { get; set; } }
    }
