using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly string _jwtSecret = "your-secret-key";



        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            byte[] key = new byte[256 / 8]; // 128 bit / 8 = 16 byte
            RandomNumberGenerator.Create().GetBytes(key);
            var securityKey = new SymmetricSecurityKey(key);

            if (model.Username == "test@test.com" && model.Password == "password")
            {
                var claims = new[]
                {
                new Claim(ClaimTypes.Name, model.Username),
                // Aggiungi altri claim se necessario
            };

                  var token = new JwtSecurityToken(
                 claims: claims,
                 expires: DateTime.UtcNow.AddHours(1), // Scadenza del token
                 signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
            );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                return Ok(new { token = tokenString, message = "Login successo" });
            }

            return Unauthorized(new { message = "Credenziali non valide" });
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Ok(new { message = "Logout successo" });
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
