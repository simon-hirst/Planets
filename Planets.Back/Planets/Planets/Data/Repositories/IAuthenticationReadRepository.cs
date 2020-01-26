using System.Threading.Tasks;
using Planets.Data.Models.Views;

namespace Planets.Data.Repositories
{
    public interface IAuthenticationReadRepository
    {
        public Task<AuthenticationView> ReadAuthentication(string hashedPassword);
    }
}