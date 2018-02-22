namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public sealed class ReversePhonesReponse : BisResponse
    {
        [JsonProperty(PropertyName = "reversePhones")]
        public List<ReversePhonesItemsResult> Results { get; set; }
    }
}
