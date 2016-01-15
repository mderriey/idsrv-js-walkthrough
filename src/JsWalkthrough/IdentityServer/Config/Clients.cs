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
                        "https://localhost:44301/popup.html",
                        "https://localhost:44301/silent-renew.html"
                    },

                    PostLogoutRedirectUris = new List<string>
                    {
                        "https://localhost:44301/index.html"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "https://localhost:44301"
                    },

                    AllowAccessToAllScopes = true,
                    AccessTokenLifetime = 70
                }
            };
        }
    }
}