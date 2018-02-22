namespace Experian.Api.Client.Tests
{
    using Experian.Api.Client;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.TestHost;

    public sealed class AuthorisationFixture
    {
        private IWebHostBuilder hostBuilder;
        private TestServer hostServer;

        public AuthorisationFixture()
        {
            hostBuilder = new WebHostBuilder();
            hostBuilder.UseWebRoot(Bis.ApiExtensions.BisStaging);
            hostServer  = new TestServer(hostBuilder);

            this.ServiceClient = new ServiceClient(hostServer.CreateClient());
            this.ClientId      = "apiClientId";
            this.ClientSecret  = "apiClientSecret";
            this.AuthRequest   = new AuthRequest(username: "DefaultUsername", password: "DefaultPassword");
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
