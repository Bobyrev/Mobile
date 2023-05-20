using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Models;

namespace Mobile.DataAccess.Contexts
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<MobileReadContext> options) : base(options)
        {

        }

        public BaseContext(DbContextOptions<MobileWriteContext> options) : base(options)
        {

        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<ColorScheme> ColorSchemes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
