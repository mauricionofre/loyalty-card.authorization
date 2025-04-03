namespace LoyaltyCard.Authorization.Domain.Models.Tokens;

public class TokenResponse
{
    public string Token { get; set; } = string.Empty;
    public DateTime Expiration { get; set; }
}
