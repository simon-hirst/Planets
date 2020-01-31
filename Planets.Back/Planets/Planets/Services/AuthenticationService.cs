using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Planets.Data.Models.Views;
using Microsoft.IdentityModel.Tokens;

namespace Planets.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private string _jwtSecret;
            private int _jwtLifespan;
            
            public AuthenticationService(string jwtSecret, int jwtLifespan)
            {
                _jwtSecret = jwtSecret;
                _jwtLifespan = jwtLifespan;
            }
            
            public AuthenticationView GetAuthenticationData(string id)
            {
                var expirationTime = DateTime.UtcNow.AddSeconds(_jwtLifespan);
                
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, id)
                    }),
                    Expires = DateTime.UtcNow.AddSeconds(_jwtLifespan),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSecret)), 
                        SecurityAlgorithms.HmacSha256Signature
                    )
                };
                
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
                        
                return new AuthenticationView(){
                    Token = token,
                    TokenExpirationTime = ((DateTimeOffset)expirationTime).ToUnixTimeSeconds(),
                    Id = id
                };
            }
    }
}