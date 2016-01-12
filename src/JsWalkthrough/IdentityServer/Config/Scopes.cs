namespace IdentityServer.Config
{
    using System.Collections.Generic;
    using IdentityServer3.Core.Models;

    public static class Scopes
    {
        public static List<Scope> Get()
        {
            return new List<Scope>
            {
                StandardScopes.OpenId,
                StandardScopes.Profile,
                StandardScopes.Email
            };
        }
    }
}