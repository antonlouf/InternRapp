using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Client;
using Microsoft.Identity.Web;
using ProxyKit;
using System.Net;
using System.Net.Http.Headers;

namespace backend_for_frontend.Configuration
{
    public static class ProxyConfiguration
    {
        public static IApplicationBuilder UseProxy(this IApplicationBuilder app, IConfiguration configuration)
        {
            string? timeslotsApiBaseUrl = configuration.GetValue<string>("Api:BaseUrl");
            string[]? timeslotsApiScopes = configuration.GetValue<string>("Api:Scopes").Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return app.Map("/api", true, api =>
            {
                api.RunProxy(async context =>
                {
                    try
                    {
                        ForwardContext? forwardContext = context.ForwardTo(timeslotsApiBaseUrl);

                        ITokenAcquisition? tokenAcquisition = context.RequestServices.GetRequiredService<ITokenAcquisition>();
                        string? token = await tokenAcquisition.GetAccessTokenForUserAsync(timeslotsApiScopes, authenticationScheme: OpenIdConnectDefaults.AuthenticationScheme);

                        forwardContext.UpstreamRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                        if (!string.IsNullOrEmpty(context.Request.ContentType) && forwardContext.UpstreamRequest.Content == null)
                        {
                            forwardContext.UpstreamRequest.Content = new ByteArrayContent(new byte[0]);
                            forwardContext.UpstreamRequest.Content.Headers.ContentType = new MediaTypeHeaderValue(context.Request.ContentType);
                        }

                        return await forwardContext.Send();
                    }
                    catch (MsalUiRequiredException)
                    {
                        HttpResponseMessage response = new(HttpStatusCode.Unauthorized)
                        {
                            Content = new StringContent("An error has occured")
                        };

                        return response;
                    }
                });
            });
        }
    }
}
