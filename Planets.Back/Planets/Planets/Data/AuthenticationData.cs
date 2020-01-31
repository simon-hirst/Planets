using System;
using Planets.Models.Entities;

namespace Planets.Data
{
    public class AuthenticationData
    {
        public static readonly AuthenticationEntity Authentication = new AuthenticationEntity()
        {
            Id = Guid.NewGuid(), Password = "DootrixTest"
        };
    }
}