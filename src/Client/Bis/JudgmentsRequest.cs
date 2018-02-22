namespace Experian.Api.Client.Bis
{
    public sealed class JudgmentsRequest : BisRequest
    {
        public bool JudgmentSummary { get; set; }

        public bool JudgmentDetail { get; set; }
    }
}
