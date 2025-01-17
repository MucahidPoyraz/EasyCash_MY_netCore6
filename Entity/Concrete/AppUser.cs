using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class AppUser : IdentityUser<Guid>
    {
        [Required]
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public List<CustomerAccount> CustomerAccounts { get; set; }
    }
}
