
using LoyaltyCard.Authorization.Domain.Models.Users;

namespace LoyaltyCard.Authorization.Domain.Interfaces;

public interface IUserService
{
    User? Authenticate(string username, string password);
}

