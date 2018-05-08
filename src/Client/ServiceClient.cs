[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Experian.Api.Client.Tests")]
namespace Experian.Api.Client
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// This is a client wrapper for HttpClient with specific configuration to use API services. You may optionally pass your own httpClient in order to control the object lifetime or apply extra settings (such as a proxy)
    /// </summary>
    public sealed class ServiceClient
    {
        public const string OAuthStagingUrl    = "https://stg-us-api.experian.com/oauth2/v1/token";
        public const string OAuthProductionUrl = "https://us-api.experian.com/oauth2/v1/token";
        public const string OAuthSandboxUrl    = "https://sandbox-us-api.experian.com/oauth2/v1/token";

        private const string JsonMediaType     = "application/json";

        private readonly HttpClient httpClient;
        private readonly JsonSerializer serializer;
        private readonly JsonSerializerSettings serializerSettings;

        public ServiceClient()
            : this(new HttpClient())
        {
        }

        public ServiceClient(HttpClient httpClient)
        {
            this.httpClient                     = httpClient;
            serializer                          = new JsonSerializer();
            serializerSettings                  = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(JsonMediaType));
        }

        public async Task<AuthResult> SendAuthenticationRequestAsync(AuthRequest credentials, string clientId, string clientSecret, string uri)
        {
            var request      = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Content  = CreateUtf8JsonContent(credentials);
            request.Headers.Add("Cache-Control", "no-cache");
            request.Headers.Add("client_id",     clientId);
            request.Headers.Add("client_secret", clientSecret);

            return await SendRequestAsync<AuthResult>(request).ConfigureAwait(false);
        }

        public async Task<TResponse> SendRequestAsync<TRequest, TResponse>(string uri, AuthResult authToken, TRequest content)
        {
            var request                   = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Headers.Authorization = new AuthenticationHeaderValue(authToken.TokenType, authToken.AccessToken);
            request.Content               = CreateUtf8JsonContent(content);

            return await SendRequestAsync<TResponse>(request).ConfigureAwait(false);
        }

        public async Task<TResponse> SendRequestAsync<TResponse>(HttpRequestMessage request)
        {
            using (var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
            {
                // Currently we throw an exception on failure - we could do some more work here to retry/reauthentication.
                if (response.IsSuccessStatusCode == false)
                {
                    var exception = CreateException(response);
                    if (exception != null)
                    {
                        throw exception;
                    }
                    else
                    {
                        response.EnsureSuccessStatusCode();
                    }
                }

                using (var stream       = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new StreamReader(stream))
                using (var jsonReader   = new JsonTextReader(streamReader))
                {
                    return serializer.Deserialize<TResponse>(jsonReader);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public HttpContent CreateUtf8JsonContent<TRequest>(TRequest content)
        {
            var httpContent = JsonConvert.SerializeObject(content, serializerSettings);

            // Note: the WithoutCharset class is used because Apigee throws unsupported media type error, despite it being a valid header value (and it does support UTF8)
            return new StringContentWithoutCharset(httpContent, Encoding.UTF8, JsonMediaType);
        }

        internal Exception CreateException(HttpResponseMessage response)
        {
            Exception exception     = null;
            using (var stream       = response.Content.ReadAsStreamAsync().Result)
            using (var streamReader = new StreamReader(stream))
            using (var jsonReader   = new JsonTextReader(streamReader))
            {
                try
                {
                    // try to obtain a BisErrorResult
                    var errorResponse = serializer.Deserialize<Bis.BisErrorResponse>(jsonReader);
                    errorResponse.HttpCode = response.StatusCode;
                    Bis.BisServiceException bisException = new Bis.BisServiceException("Recieved HTTP Code:" + errorResponse.HttpCode.ToString() + " See Errors collection for more details", errorResponse);
                }
                catch (JsonSerializationException)
                {
                }
            }

            return exception;
        }
    }
}
