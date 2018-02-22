namespace Experian.Api.Client.Bis
{
    using System;

    public sealed class BankruptcyReponse : BisResponse
    {
        public BankruptcyResult Results { get; set; }
    }
}
