namespace Experian.Api.Client.Bis
{
public sealed class TradePaymentTotalsResult
{
    public TradelinesResult Tradelines { get; set; }

    public NewlyReportedTradelinesResult NewlyReportedTradelines { get; set; }

    public ContinuouslyReportedTradelinesResult ContinuouslyReportedTradelines { get; set; }

    public CombinedTradelinesResult CombinedTradelines { get; set; }

    public AdditionalTradelinesResult AdditionalTradelines { get; set; }
}
}
