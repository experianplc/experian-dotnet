namespace Experian.Api.Client.Bis
{
    public sealed class BankruptcyRequest : BisRequest
    {
        public bool BankruptcySummary { get; set; }

        public bool BankruptcyDetail { get; set; }
    }
}
