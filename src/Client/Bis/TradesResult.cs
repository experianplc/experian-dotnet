namespace Experian.Api.Client.Bis
{
    public class TradesResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public TradePaymentSummaryResult TradePaymentSummary { get; set; }

        public TradePaymentTotalsResult TradePaymentTotals { get; set; }

        public TradePaymentExperiencesResult TradePaymentExperiences { get; set; }

        public TradePaymentTrendsResult TradePaymentTrends { get; set; }

        public bool IsTradeIndicator { get; set; }
    }
}
