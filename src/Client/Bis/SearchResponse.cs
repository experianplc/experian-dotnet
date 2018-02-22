namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;

    public sealed class SearchReponse : BisResponse
    {
        public List<SearchResult> Results { get; set; }
    }
}
