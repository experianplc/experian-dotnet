namespace Experian.Api.Client.Bis
{
    public sealed class LegalCollectionsSummariesRequest : BisRequest
    {
        public bool LegalFilingsCollectionsSummary { get; set; }

        public bool LegalFilingsSummary { get; set; }
    }
}
