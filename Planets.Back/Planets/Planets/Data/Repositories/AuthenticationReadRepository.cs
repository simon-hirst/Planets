using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planets.Data.Models.Entities;
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
        
        public async Task<bool> Verify(LoginView login)
        {
            if (!await _dbContext.AuthenticationDb.AnyAsync())
                return false;

            if (await _dbContext.AuthenticationDb.AnyAsync(authentication => authentication.Password == login.Password))
                return true;

            return false;
        }
    }
}