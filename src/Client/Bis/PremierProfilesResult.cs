namespace Experian.Api.Client.Bis
{
    public sealed class PremierProfilesResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public PremierProfilesExpandedCreditSummary ExpandedCreditSummary { get; set; }

        public PremierProfilesExecutiveSummary ExecutiveSummary { get; set; }
    }
}
