namespace Experian.Api.Client.Bis
{
    public sealed class PremierProfilesRequest : BisRequest
    {
        public string ModelCode { get; set; }

        public string Comments { get; set; }
    }
}