using System;
using Planets.Data.Models.Entities;

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