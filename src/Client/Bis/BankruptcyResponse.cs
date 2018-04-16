namespace Experian.Api.Client.Bis
{
    using System;

    public sealed class BankruptcyResponse : BisResponse
    {
        public BankruptcyResult Results { get; set; }
    }
}
