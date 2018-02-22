namespace Experian.Api.Client.Bis
{
public sealed class TradesRequest : BisRequest
{
    public bool TradePaymentSummary { get; set; }

    public bool TradePaymentTotals { get; set; }

    public bool TradePaymentExperiences { get; set; }

    public bool TradePaymentTrends { get; set; }
}
}
