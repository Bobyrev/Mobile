using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configurations;

namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Должность
    /// </summary>
    [EntityTypeConfiguration(typeof(PositionConfigurations))]
    public class Position : BaseNamedModel<long>
    {
    }
}
