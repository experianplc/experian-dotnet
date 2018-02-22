namespace Experian.Api.Client.Bis
{
    public class MonthlyTrendsResult
    {
        public string Date { get; set; }

        public int Dbt { get; set; }

        public TotalAccountBalanceResult TotalAccountBalance { get; set; }

        public int CurrentPercentage { get; set; }

        public int Dbt30 { get; set; }

        public int Dbt60 { get; set; }

        public int Dbt90 { get; set; }

        public int Dbt91Plus { get; set; }
    }
}
