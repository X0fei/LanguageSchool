using System.Collections.Generic;
using System.Linq;
using LanguageSchool.Models;

namespace LanguageSchool.Services
{
    public class UserService
    {
        // Список пользователей, доступный на этапе разработки
        private static List<User> _users = new List<User>
        {
            new User("admin", "0000", true),
            new User("user", "0000", false)
        };

        public List<User> GetUsers()
        {
            return _users;
        }

        public User GetUser(string username)
        {
            return _users.FirstOrDefault(u => u.Username == username);
        }

        public bool IsUserAdmin(string username)
        {
            var user = GetUser(username);
            return user != null && user.IsAdmin;
        }
    }
}