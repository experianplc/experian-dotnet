namespace Experian.Api.Client.Bis
{
    public class CollectionsRequest : BisRequest
    {
        public bool CollectionsSummary { get; set; }

        public bool CollectionsDetail { get; set; }
    }
}