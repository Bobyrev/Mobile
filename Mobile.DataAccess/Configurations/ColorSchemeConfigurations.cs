using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobile.DataAccess.Models;

namespace Mobile.DataAccess.Configurations
{
    public class ColorSchemeConfigurations : IEntityTypeConfiguration<ColorScheme>
    {
        public void Configure(EntityTypeBuilder<ColorScheme> builder)
        {
            builder.ToTable("ColorSchemes");
            builder.HasKey(x => x.Id);

            builder
                .HasOne(x => x.Settings)
                .WithOne(x => x.ColorScheme)
                .HasForeignKey<Settings>(x => x.ColorSchemeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
