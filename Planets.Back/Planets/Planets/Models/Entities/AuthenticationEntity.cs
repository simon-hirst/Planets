using System;

namespace Planets.Data.Models.Entities
{
    public class AuthenticationEntity
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
    }
}