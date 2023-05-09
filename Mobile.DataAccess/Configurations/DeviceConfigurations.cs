using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobile.DataAccess.Models;

namespace Mobile.DataAccess.Configurations
{
    public class DeviceConfigurations : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.ToTable("Devices");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.DeviceCode).IsUnique();
            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Devices)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
