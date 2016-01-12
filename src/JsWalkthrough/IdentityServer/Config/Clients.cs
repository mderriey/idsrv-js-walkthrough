namespace IdentityServer.Config
{
    using System.Collections.Generic;
    using IdentityServer3.Core.Models;

    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
                new Client
                {
                    Enabled = true,
                    ClientName = "JS Client",
                    ClientId = "js",
                    Flow = Flows.Implicit,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:56668/popup.html",
                        "http://localhost:56668/silent-renew.html"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:56668"
                    },

                    AllowAccessToAllScopes = true,
                    AccessTokenLifetime = 70
                }
            };
        }
    }
}