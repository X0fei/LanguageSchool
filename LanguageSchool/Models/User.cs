namespace LanguageSchool.Models
{
    /// <summary>
    /// Представляет пользователя в системе. Создан на время разработки.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Получает или задаёт имя пользователя.
        /// </summary>
        /// <value>Имя пользователя</value>
        public string Username { get; set; }
        
        /// <summary>
        /// Получает или задаёт пароль пользователя.
        /// </summary>
        /// <value>Пароль пользователя</value>
        public string Password { get; set; }
        
        /// <summary>
        /// Получает или задаёт, является ли пользователь администратором.
        /// </summary>
        /// <value><c>true</c>, если пользователь является администратором; в противном случае <c>false</c>.</value>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="User"/>.
        /// </summary>
        /// <param name="username">Имя пользователя.</param>
        /// <param name="password">Пароль пользователя.</param>
        /// <param name="isAdmin">Определяет, является ли пользователь администратором.</param>
        public User(string username, string password, bool isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}