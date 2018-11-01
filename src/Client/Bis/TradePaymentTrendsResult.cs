namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;

    public sealed class TradePaymentTrendsResult
    {
        public List<MonthlyTrendsResult> MonthlyTrends { get; set; }

        public List<QuarterlyTrendsResult> QuarterlyTrends { get; set; }
    }
}
