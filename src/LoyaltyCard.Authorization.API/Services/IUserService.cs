using LoyaltyCard.Authorization.API.Models;

namespace LoyaltyCard.Authorization.API.Services
{
    public interface IUserService
    {
        User? Authenticate(string username, string password);
    }
}
