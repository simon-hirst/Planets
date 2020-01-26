using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Planets.Data.Models.Views;

namespace Planets.Data.Repositories
{
    public class AuthenticationReadRepository : IAuthenticationReadRepository
    {
        private readonly PlanetsContext _dbContext;

        public AuthenticationReadRepository(PlanetsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AuthenticationView> ReadAuthentication(string hashedPassword)
        {
            var result = await _dbContext.AuthenticationDb.FirstOrDefaultAsync(authentication =>
                authentication.HashedPassword == hashedPassword);

            return new AuthenticationView
            {
                IsValid = result != null
            };
        }
    }
}