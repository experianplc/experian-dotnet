namespace Experian.Api.Client
{
    using System;
    using Newtonsoft.Json;

    public sealed class AuthResult : IAuthToken
    {
        internal static readonly DateTime EpochUtc = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        internal static readonly long     EpochMS  = 62135596800000;

        [JsonProperty("issued_at")]
        public long IssuedAt      { get; set; }

        [JsonProperty("expires_in")]
        public long ExpiresIn     { get; set; }

        [JsonProperty("token_type")]
        public string TokenType   { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonIgnore]
        public long ExpiresAt
        {
            get { return IssuedAt + ExpiresIn; }
        }

        [JsonIgnore]
        public string Value
        {
            get { return this.AccessToken; }
        }

        [JsonIgnore]
        public bool IsExpired
        {
            get
            {
                return ExpiresAt < ((DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond) - EpochMS);
            }
        }
    }
}
