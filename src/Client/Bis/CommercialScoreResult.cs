namespace Experian.Api.Client.Bis
{
    public class CommercialScoreResult
    {
        public string ModelCode { get; set; }

        public string ModelTitle { get; set; }

        public string CustomModelCode { get; set; }

        public int Score { get; set; }

        public int PercentileRanking { get; set; }

        public int? RecommendedCreditLimitAmount { get; set; }

        public RiskClassResult RiskClass { get; set; }
    }
}
