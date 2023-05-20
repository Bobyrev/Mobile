using Microsoft.EntityFrameworkCore;
using Mobile.DataAccess.Configurations;

namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Позиция
    /// </summary>
    [EntityTypeConfiguration(typeof(PlaceConfigurations))]
    public class Place : BaseNamedModel<long>
    {
    }
}
