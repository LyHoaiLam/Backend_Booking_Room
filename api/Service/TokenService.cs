using System.Security.Claims;
using System.Text;
using api.Interfaces;
using api.models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace api.Service {
    public class TokenService : ITokenService{
        private readonly IConfiguration _config;
        private readonly SymmetricSecurityKey _key;

        public TokenService(IConfiguration config) {
            _config = config;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:SigningKey"]));
        }

        public string CreateToken(AppUser user) {

            Console.WriteLine("CreateToken Folder Service - AppUser: ", user);

            var claims = new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.GivenName, user.UserName),
            };

            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptior = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = creds,
                Issuer = _config["JWT:Issuer"],
                Audience = _config["JWT:Audience"]
            };

            Console.WriteLine("tokenDescriptior: ", tokenDescriptior);


            var tokenHandler = new JwtSecurityTokenHandler();
            Console.WriteLine("tokenHandler: ", tokenHandler);

            var token = tokenHandler.CreateToken(tokenDescriptior);
            Console.WriteLine("token: ", token);

            return tokenHandler.WriteToken(token);

        }

    }
}