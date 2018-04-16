namespace Experian.Api.Client.Bis
{
    public sealed class ScoresRequest : BisRequest
    {
        public string ModelCode { get; set; }

        public bool FsrScore { get; set; }

        public bool CommercialScore { get; set; }
    }
}