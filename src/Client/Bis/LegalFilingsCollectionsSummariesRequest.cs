namespace Experian.Api.Client.Bis
{
    public sealed class LegalFilingsCollectionsSummariesRequest : BisRequest
    {
        public bool LegalFilingsCollectionsSummary { get; set; }

        public bool LegalFilingsSummary { get; set; }
    }
}
