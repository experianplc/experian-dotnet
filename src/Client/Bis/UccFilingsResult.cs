namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;

    public sealed class UccFilingsResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public UccFilingsSummaryResult UccFilingsSummary { get; set; }

        public List<UccFilingsDetailResult> UccFilingsDetail { get; set; }

        public bool UccFilingIndicator { get; set; }
    }
}
