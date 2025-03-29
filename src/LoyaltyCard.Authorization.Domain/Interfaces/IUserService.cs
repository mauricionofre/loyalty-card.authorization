using LoyaltyCard.Authorization.Domain.Models;

namespace LoyaltyCard.Authorization.Domain.Interfaces;

public interface IUserService
{
    User? Authenticate(string username, string password);
}

