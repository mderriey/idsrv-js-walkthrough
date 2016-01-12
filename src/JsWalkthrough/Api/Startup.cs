namespace Api
{
    using System.Web.Http;
    using IdentityServer3.AccessTokenValidation;
    using Microsoft.Owin.Cors;
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Wire token validation
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "https://localhost:44300",

                // For access to the introspection endpoint
                ClientId = "api-introspection",
                ClientSecret = "api-secret",

                RequiredScopes = new[] { "api" }
            });

            // Allow all origins
            app.UseCors(CorsOptions.AllowAll);

            // Wire Web API
            var httpConfiguration = new HttpConfiguration();
            httpConfiguration.MapHttpAttributeRoutes();
            httpConfiguration.Filters.Add(new AuthorizeAttribute());

            app.UseWebApi(httpConfiguration);
        }
    }
}