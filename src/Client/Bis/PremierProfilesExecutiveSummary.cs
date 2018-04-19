namespace Experian.Api.Client.Bis
{
    public sealed class PremierProfilesExecutiveSummary
    {
        public CodeAndDefinitionResult IndustryPaymentComparison { get; set; }

        public CodeAndDefinitionResult PaymentTrendIndicator { get; set; }

        public int AllIndustryDbt { get; set; }

        public int IndustryDbt { get; set; }

        public CodeAndDefinitionResult BusinessDbt { get; set; }

        public int? PredictedDbt { get; set; }

        public PremierProfilesCommonTerms CommonTerms { get; set; }
    }
}
