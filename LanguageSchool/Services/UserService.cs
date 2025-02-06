using System.Collections.Generic;
using System.Linq;
using LanguageSchool.Models;

namespace LanguageSchool.Services
{
    /// <summary>
    /// Предоставляет функциональность для управления пользователями в приложении.
    /// </summary>
    public static class UserService
    {
        /// <summary>
        /// Статический список пользователей, используемый на этапе разработки.
        /// </summary>
        private static readonly List<User> _users =
        [
            new User("admin", "0000", true),
            new User("user", "0000", false)
        ];

        /// <summary>
        /// Возвращает пользователя по его имени пользователя (username).
        /// </summary>
        /// <param name="username">Имя пользователя, по которому производится поиск.</param>
        /// <returns>
        /// Объект <see cref="User"/>, если пользователь найден; в противном случае — <c>null</c>.
        /// </returns>
        public static User? GetUser(string? username)
        {
            return _users.FirstOrDefault(u => u.Username == username);
        }

        /// <summary>
        /// Проверяет, является ли пользователь с указанным именем администратором.
        /// </summary>
        /// <param name="username">Имя пользователя для проверки прав администратора.</param>
        /// <returns>
        /// <c>true</c>, если пользователь существует и имеет права администратора; 
        /// в противном случае — <c>false</c>.
        /// </returns>
        public static bool IsUserAdmin(string username)
        {
            var user = GetUser(username);
            return user is { IsAdmin: true };
        }
    }
}