namespace Experian.Api.Client.Bis
{
    public class BisResponse
    {
        public string RequestId { get; set; }

        public bool   Success   { get; set; }

        public string Comments  { get; set; }
    }
}