using System;

namespace Planets.Models.Entities
{
    public class AuthenticationEntity
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
    }
}