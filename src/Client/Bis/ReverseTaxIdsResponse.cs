namespace Experian.Api.Client.Bis
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

public sealed class ReverseTaxIdsReponse : BisResponse
{
        [JsonProperty(PropertyName = "reverseTaxIds")]
        public List<ReverseTaxIdsItemsResult> Results { get; set; }
    }
}
