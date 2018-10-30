namespace Experian.Api.Client.Bis
{
    public sealed class CorporateLinkageRequest : BisRequest
    {
        public string ModelCode { get; set; }

        public bool CorporateLinkagePartial { get; set; }

        public bool CorporateLinkageFull { get; set; }
    }
}
