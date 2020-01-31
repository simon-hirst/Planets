using System.Threading.Tasks;
using Planets.Models.Views;

namespace Planets.Data.Repositories
{
    public interface IAuthenticationReadRepository
    {
        Task<bool> Verify(LoginView login);
    }
}