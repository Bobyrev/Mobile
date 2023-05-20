using MediatR;
using Mobile.ApiContracts.Team.Query.Models;
using System.ComponentModel.DataAnnotations;

namespace Mobile.ApiContracts.Team.Query
{
    /// <summary>
    /// Получение пользователей одной команды
    /// </summary>
    public class GetTeamUsersQuery : IRequest<IEnumerable<UserViewModel>>, IValidatableObject
    {
        /// <summary>
        /// Идентификатор группы
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// Наименование группы
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Валидация
        /// </summary>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Id is null && string.IsNullOrEmpty(Name))
                yield return new ValidationResult("Нет информации о команде", new List<string> { nameof(Id), nameof(Name) });
        }
    }
}
