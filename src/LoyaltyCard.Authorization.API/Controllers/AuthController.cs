using LoyaltyCard.Authorization.API.Models;
using LoyaltyCard.Authorization.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoyaltyCard.Authorization.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;
        
        public AuthController(ITokenService tokenService, IUserService userService)
        {
            _tokenService = tokenService;
            _userService = userService;
        }
        
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _userService.Authenticate(request.Username, request.Password);
            
            if (user == null)
                return Unauthorized(new { message = "Username or password is incorrect" });
                
            var tokenResponse = _tokenService.GenerateToken(user);
            
            return Ok(tokenResponse);
        }
    }
}
