namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Базовая модель с наименованием
    /// </summary>
    public class BaseNamedModel<T> : BaseModel<T> where T : struct
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = null!;
    }
}
