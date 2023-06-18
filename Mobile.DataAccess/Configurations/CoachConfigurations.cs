using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobile.DataAccess.Models;

namespace Mobile.DataAccess.Configurations
{
    public class CoachConfigurations : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.ToTable("Coaches");
            builder
                .HasOne(x => x.Team)
                .WithMany(x => x.Coaches);

            builder.HasOne(x => x.Position);
        }
    }
}
