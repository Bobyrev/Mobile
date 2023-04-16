namespace Mobile.DataAccess.Models
{
    /// <summary>
    /// Базовая модель
    /// </summary>
    /// <typeparam name="T">тип идентификатора</typeparam>
    public class BaseModel<T> where T : struct
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public T Id { get; set; }

        /// <summary>
        /// Дата создания записи
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Дата последнего изменения записи
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
    }
}
