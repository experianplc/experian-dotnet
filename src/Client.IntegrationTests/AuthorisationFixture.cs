namespace Experian.Api.Client.IntegrationTests
{
    using System;
    using System.Net.Http;
    using Microsoft.Extensions.Configuration;

    public sealed class AuthorisationFixture
    {
        public AuthorisationFixture()
        {
            this.ClientId      = Environment.GetEnvironmentVariable("apiClientId");
            this.ClientSecret  = Environment.GetEnvironmentVariable("apiClientSecret");

            this.AuthRequest   = new AuthRequest(
                username: Environment.GetEnvironmentVariable("apiUsername"),
                password: Environment.GetEnvironmentVariable("apiPassword"));

            if (string.IsNullOrEmpty(ClientId))
            {
                // You can setup your local machine (win/mac/lin) with the following commands in the Client.IntegrationTests folder
                // dotnet user-secrets set ClientId YOURCLIENTID
                // dotnet user-secrets set ClientSecret YOURCLIENTSECRET
                // dotnet user-secrets set Username YOURUSERNAME
                // dotnet user-secrets set Password YOURPASSWORD
                var builder = new ConfigurationBuilder()
                            .AddUserSecrets("54395833-943C-44D8-B016-134793AA52EB");

                var configuration = builder.Build();
                this.ClientId     = configuration["ClientId"];
                this.ClientSecret = configuration["ClientSecret"];
                this.AuthRequest  = new AuthRequest(
                                                    configuration["Username"],
                                                    configuration["Password"]);
            }

            HttpClient client  = new HttpClient();
            this.ServiceClient = new ServiceClient(client);
        }

        public AuthRequest AuthRequest     { get; }

        public AuthResult AuthResult     { get; private set; }

        public string ClientId             { get; }

        public string ClientSecret         { get; }

        public ServiceClient ServiceClient { get; }

        public AuthResult ObtainAuthToken()
        {
            if (AuthResult == null)
            {
                this.AuthResult = ServiceClient.SendAuthenticationRequestAsync(this.AuthRequest, ClientId, ClientSecret, ServiceClient.OAuthSandboxUrl).Result;
            }

            return this.AuthResult;
        }
    }
}
