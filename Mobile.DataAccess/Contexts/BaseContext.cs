using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Models;

namespace Mobile.DataAccess.Contexts
{
    public class BaseContext : DbContext
    {
        public BaseContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Device> Devices { get; set; }
    }
}
