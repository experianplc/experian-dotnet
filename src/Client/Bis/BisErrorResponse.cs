namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;
    using System.Net;
    using Newtonsoft.Json;

    public sealed class BisErrorResponse : BisResponse
    {
        [JsonIgnore]
        public HttpStatusCode HttpCode { get; set; }

        public List<BisErrorResult> Errors { get; set; }
    }
}