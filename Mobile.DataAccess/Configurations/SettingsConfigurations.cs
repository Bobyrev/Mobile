using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobile.DataAccess.Models;

namespace Mobile.DataAccess.Configurations
{
    public class SettingsConfigurations : IEntityTypeConfiguration<Settings>
    {
        public void Configure(EntityTypeBuilder<Settings> builder)
        {
            builder.ToTable("Settings");
            builder.HasKey(x => x.Id);
            builder
                .HasOne(x => x.ColorScheme)
                .WithMany(x => x.Settings)
                .HasForeignKey(x => x.ColorSchemeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
