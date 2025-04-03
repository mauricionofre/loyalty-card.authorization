using System;

namespace LoyaltyCard.Authorization.Domain.Models.Users;

public class User
{
    public string Id { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty; // In a real scenario, store password hash
    public List<string> Roles { get; set; } = new List<string>();
}