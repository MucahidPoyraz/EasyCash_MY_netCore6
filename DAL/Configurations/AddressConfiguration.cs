using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasOne(a => a.City).WithMany(c => c.Addresses).HasForeignKey(a => a.CityId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.District).WithMany(d => d.Addresses).HasForeignKey(a => a.DistrictId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
