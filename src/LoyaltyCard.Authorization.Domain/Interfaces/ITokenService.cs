

using LoyaltyCard.Authorization.Domain.Models;

namespace LoyaltyCard.Authorization.Domain.Interfaces;

public interface ITokenService
{
    TokenResponse GenerateToken(User user);
}

