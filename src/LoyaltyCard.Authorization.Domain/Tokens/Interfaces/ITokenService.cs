
using LoyaltyCard.Authorization.Domain.Models.Tokens;
using LoyaltyCard.Authorization.Domain.Models.Users;

namespace LoyaltyCard.Authorization.Domain.Interfaces;

public interface ITokenService
{
    TokenResponse GenerateToken(User user);
}

