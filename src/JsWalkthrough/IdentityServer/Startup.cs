namespace IdentityServer
{
    using System;
    using System.IO;
    using System.Security.Cryptography.X509Certificates;
    using Config;
    using IdentityServer3.Core.Configuration;
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIdentityServer(new IdentityServerOptions
            {
                SiteName = "Embedded IdentityServer",
                SigningCertificate = LoadCertificate(),

                Factory = new IdentityServerServiceFactory()
                    .UseInMemoryClients(Clients.Get())
                    .UseInMemoryUsers(Users.Get())
                    .UseInMemoryScopes(Scopes.Get())
            });
        }

        X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\Config\idsrv3test.pfx"), "idsrv3test");
        }
    }
}