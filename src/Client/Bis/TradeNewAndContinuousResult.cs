namespace Experian.Api.Client.Bis
{
    public class TradeNewAndContinuousResult
    {
        public string BusinessCategory { get; set; }

        public string DateReported { get; set; }

        public string DateLastActivity { get; set; }

        public string Terms { get; set; }

        public RecentHighCreditResult RecentHighCredit { get; set; }

        public AccountBalanceResult AccountBalance { get; set; }

        public int CurrentPercentage { get; set; }

        public int Dbt30 { get; set; }

        public int Dbt60 { get; set; }

        public int Dbt90 { get; set; }

        public int Dbt91Plus { get; set; }

        public string Comments { get; set; }

        public bool NewlyReportedIndicator { get; set; }

        public bool CustomerDisputeIndicator { get; set; }
    }
}
