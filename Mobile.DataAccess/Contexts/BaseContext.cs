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
    }
}
