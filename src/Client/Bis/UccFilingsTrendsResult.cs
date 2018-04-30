namespace Experian.Api.Client.Bis
{
    public class UccFilingsTrendsResult
    {
        public string Date { get; set; }

        public int Count { get; set; }

        public int DerogatoryCount { get; set; }

        public int ReleasesAndTerminationsCount { get; set; }

        public int ContinuationsCount { get; set; }

        public int AmendedAndAssignedCount { get; set; }
    }
}