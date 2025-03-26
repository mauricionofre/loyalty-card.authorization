using LoyaltyCard.Authorization.API.Models;

namespace LoyaltyCard.Authorization.API.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>
        {
            new User 
            { 
                Id = "1", 
                Username = "admin", 
                Password = "admin123", // In real scenario, use hashed passwords
                Roles = new List<string> { "Admin" } 
            },
            new User 
            { 
                Id = "2", 
                Username = "user", 
                Password = "user123",
                Roles = new List<string> { "User" } 
            }
        };

        public User? Authenticate(string username, string password)
        {
            return _users.SingleOrDefault(u => 
                u.Username == username && 
                u.Password == password);
        }
    }
}
