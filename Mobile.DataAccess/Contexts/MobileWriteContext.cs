using Microsoft.EntityFrameworkCore;

namespace Mobile.DataAccess.Contexts
{
    public class MobileWriteContext : BaseContext
    {
        public MobileWriteContext(DbContextOptions<MobileWriteContext> options) : base(options)
        {

        }
    }
}