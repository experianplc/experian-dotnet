namespace Experian.Api.Client.Bis
{
    public sealed class PremierProfilesResponse : BisResponse
    {
        public PremierProfilesResult Results { get; set; }
    }

    public sealed class PremierProfilesResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public ExpandedCreditSummary ExpandedCreditSummary { get; set; }

        public ExecutiveSummary ExecutiveSummary { get; set; }
    }

    public sealed class ExpandedCreditSummary
    {
        public int? LowBalance6Months { get; set; }

        public int? HighBalance6Months { get; set; }
    }

    public sealed class ExecutiveSummary
    {
        public CodeAndDefinitionResult IndustryPaymentComparison { get; set; }

        public CodeAndDefinitionResult PaymentTrendIndicator { get; set; }

        public int AllIndustryDbt { get; set; }

        public int IndustryDbt { get; set; }

        public CodeAndDefinitionResult BusinessDbt { get; set; }

        public int? PredictedDbt { get; set; }

        public CommonTerms CommonTerms { get; set; }
    }

    public sealed class CommonTerms
    {
        public string First { get; set; }

        public string Second { get; set; }

        public string Third { get; set; }
    }
}