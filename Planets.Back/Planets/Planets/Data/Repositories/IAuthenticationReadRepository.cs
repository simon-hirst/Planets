using System.Collections.Generic;
using System.Threading.Tasks;
using Planets.Data.Models.Views;

namespace Planets.Data.Repositories
{
    public interface IAuthenticationReadRepository
    {
        Task<bool> Verify(LoginView login);
    }
}