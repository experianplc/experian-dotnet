namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public sealed class ReversePhonesResponse : BisResponse
    {
        [JsonProperty(PropertyName = "reversePhones")]
        public List<ReversePhonesItemsResult> Results { get; set; }
    }
}
