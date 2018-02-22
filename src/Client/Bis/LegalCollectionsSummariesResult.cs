namespace Experian.Api.Client.Bis
{
    public sealed class LegalCollectionsSummariesResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public LegalFilingsSummaryResult LegalFilingsSummary { get; set; }

        public LegalFilingsCollectionsSummaryResult LegalFilingsCollectionsSummary { get; set; }
    }
}
