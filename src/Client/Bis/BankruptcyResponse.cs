namespace Experian.Api.Client.Bis
{
    public sealed class BankruptcyResponse : BisResponse
    {
        public BankruptcyResult Results { get; set; }
    }
}
