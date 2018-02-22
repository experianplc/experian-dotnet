namespace Experian.Api.Client.Bis
{
    using System;
    using System.Collections.Generic;

    public sealed class UccFilingsSummaryResult
    {
        public int UccFilingsCount { get; set; }

        public List<UccFilingsTrendsResult> UccFilingsTrends { get; set; }
    }
}
