namespace Experian.Api.Client.Bis
{
    public sealed class RiskDashboardsResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public int CommercialScore { get; set; }

        public string CommercialScoreRiskClass { get; set; }

        public int FsrScore { get; set; }

        public string FsrScoreRiskClass { get; set; }

        public int RecommendedCreditLimitAmount { get; set; }

        public int CurrentDbt { get; set; }

        public int DerogatoryLegalCount { get; set; }

        public int CommercialFraudRiskIndicatorCount { get; set; }
    }
}
