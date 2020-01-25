using Planets.Data.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planets.Data.Repositories
{
    public interface IAuthenticationReadRepository
    {
        public Task<AuthenticationView> ReadAuthentication(string hashedPassword);
    }
}
