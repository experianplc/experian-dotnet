namespace Experian.Api.Client.Bis
{
    public sealed class UccFilingsRequest : BisRequest
    {
        public bool UccFilingsSummary { get; set; }

        public bool UccFilingsDetail { get; set; }
    }
}
