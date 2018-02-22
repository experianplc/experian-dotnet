namespace Experian.Api.ClientBenchmark
{
    using System;
    using Experian.Api.Client;
    using Experian.Api.Client.Bis;
    using Microsoft.Extensions.Configuration;

    internal sealed class Program
    {
        private static readonly ReverseAddressesRequest ReverseAddressRequest
                                          = new ReverseAddressesRequest()
                                            {
                                                Subcode = "0517614",
                                                Street  = "1 Infinite Loop",
                                                City    = "Cupertino",
                                                State   = "CA",
                                                Zip     = "10118",
                                            };

        public static IConfigurationRoot Configuration { get; set; }

        public static string ClientId     { get; set; }

        public static string ClientSecret { get; set; }

        public static string Username     { get; set; }

        public static string Password     { get; set; }

        private static void Main(string[] args)
        {
            // You can setup your local machine (win/mac/lin) with the following commands in the Client.Benchmark folder
            // dotnet user-secrets set ClientId YOURCLIENTID
            // dotnet user-secrets set ClientSecret YOURCLIENTSECRET
            // dotnet user-secrets set Username YOURUSERNAME
            // dotnet user-secrets set Password YOURPASSWORD
            var builder   = new ConfigurationBuilder()
                                    .AddUserSecrets("ECFF78F2-1ACD-43B4-BEB5-79FC4347B04A");

            Configuration = builder.Build();
            ClientId      = Configuration["ClientId"];
            ClientSecret  = Configuration["ClientSecret"];
            Username      = Configuration["Username"];
            Password      = Configuration["Password"];

            var serviceClient  = new ServiceClient();
            var authResult     = serviceClient.SendAuthenticationRequestAsync(new AuthRequest(Username, Password), ClientId, ClientSecret, ServiceClient.OAuthSandboxUrl).Result;
            Console.WriteLine(authResult.AccessToken);

            var response       = serviceClient.PostReverseAddressAsync(Environ.Sandbox, authResult, ReverseAddressRequest).Result;
            Console.WriteLine(response.Success);
            Console.ReadKey();
        }
    }
}
