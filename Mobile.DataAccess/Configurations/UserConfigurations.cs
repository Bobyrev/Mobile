using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobile.DataAccess.Models;

namespace Mobile.DataAccess.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder
                .HasOne(x => x.Settings)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.SettingsId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
