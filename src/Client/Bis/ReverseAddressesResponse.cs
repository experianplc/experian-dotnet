namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public sealed class ReverseAddressesReponse : BisResponse
    {
        [JsonProperty(PropertyName = "reverseAddresses")]
        public List<ReverseAddressesItemsResult> Results { get; set; }
    }
}
