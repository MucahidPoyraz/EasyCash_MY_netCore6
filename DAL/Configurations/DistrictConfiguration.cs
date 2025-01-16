using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasOne(d => d.City).WithMany(c => c.Districts).HasForeignKey(d => d.CityId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
