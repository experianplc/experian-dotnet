namespace Experian.Api.Client.Bis
{
    public class LiensRequest : BisRequest
    {
        public bool LienSummary { get; set; }

        public bool LienDetail { get; set; }
    }
}
