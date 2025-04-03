
using LoyaltyCard.Authorization.Domain.Interfaces;
using LoyaltyCard.Authorization.Domain.Models;
using LoyaltyCard.Authorization.Domain.Models.Users;
using Microsoft.Extensions.Logging;

namespace LoyaltyCard.Authorization.Application.Services;

public class UserService(ILogger<UserService> logger) : IUserService
{
    private readonly ILogger<UserService> _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    private readonly List<User> _users = new List<User>
        {
            new User
            {
                Id = "1",
                Email = "admin@example.com",
                Password = "admin123", // In real scenario, use hashed passwords
                Roles = new List<string> { "Admin" }
            },
            new User
            {
                Id = "2",
                Email = "user@example.com",
                Password = "user123",
                Roles = new List<string> { "User" }
            }
        };

    public User? Authenticate(string username, string password)
    {
        _logger.LogInformation("Authenticating user {Username}", username);

        return _users.SingleOrDefault(u =>
            u.Email == username &&
            u.Password == password);
    }
}
