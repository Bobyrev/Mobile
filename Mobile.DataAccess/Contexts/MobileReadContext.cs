using Microsoft.EntityFrameworkCore;

namespace Mobile.DataAccess.Contexts
{
    public class MobileReadContext : BaseContext
    {
        public MobileReadContext(DbContextOptions<MobileReadContext> options) : base(options)
        {
        }
    }
}