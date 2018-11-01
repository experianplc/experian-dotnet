namespace Experian.Api.Client.Bis
{
    public sealed class FraudShieldsResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public string MatchingBusinessAddress { get; set; }

        public bool ActiveBusinessIndicator { get; set; }

        public OFACMatchWarningResult OfacMatchWarning { get; set; }

        public bool BusinessVictimStatementIndicator { get; set; }

        public bool BusinessRiskTriggersIndicator { get; set; }

        public string BusinessRiskTriggersStatement { get; set; }

        public bool NameAddressVerificationIndicator { get; set; }
    }
}
