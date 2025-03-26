using LoyaltyCard.Authorization.API.Models;

namespace LoyaltyCard.Authorization.API.Services
{
    public interface ITokenService
    {
        TokenResponse GenerateToken(User user);
    }
}
