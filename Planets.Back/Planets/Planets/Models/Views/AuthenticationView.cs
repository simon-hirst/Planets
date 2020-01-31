namespace Planets.Data.Models.Views
{
    public class AuthenticationView
    {
        public string Token { get; set; }
        public long TokenExpirationTime { get; set; }
        public string Id { get; set; }
    }
}