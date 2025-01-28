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
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public User(string username, string password, bool isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}