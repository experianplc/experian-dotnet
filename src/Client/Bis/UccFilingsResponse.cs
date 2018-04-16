namespace Experian.Api.Client.Bis
{
    public sealed class UccFilingsResponse : BisResponse
    {
        public UccFilingsSummaryResult Results { get; set; }
    }
}
