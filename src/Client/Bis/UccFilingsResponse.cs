namespace Experian.Api.Client.Bis
{
    public sealed class UccFilingsReponse : BisResponse
    {
        public UccFilingsSummaryResult Results { get; set; }
    }
}
