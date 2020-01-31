using Planets.Data.Models.Views;

namespace Planets.Services
{
    public interface IAuthenticationService
    {
        AuthenticationView GetAuthenticationData(string id);
    }
}