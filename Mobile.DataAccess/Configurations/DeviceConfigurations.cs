using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobile.DataAccess.Models;

namespace Mobile.DataAccess.Configuration
{
    public class DeviceConfigurations : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.ToTable("Devices");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserEmail).IsRequired();
            builder.HasIndex(x => x.DeviceCode).IsUnique();
        }
    }
}
