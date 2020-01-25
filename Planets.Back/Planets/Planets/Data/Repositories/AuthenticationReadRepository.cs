using Microsoft.EntityFrameworkCore;
using Planets.Data.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var result = await _dbContext.AuthenticationDb.FirstOrDefaultAsync(authentication => authentication.hashedPassword == hashedPassword);

            return new AuthenticationView
            {
                isValid = result != null
            };
        }
    }
}
