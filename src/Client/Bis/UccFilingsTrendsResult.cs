namespace Experian.Api.Client.Bis
{
    public class UccFilingsTrendsResult
    {
        private string Date { get; set; }

        private int Count { get; set; }

        private int DerogatoryCount { get; set; }

        private int ReleasesAndTerminationsCount { get; set; }

        private int ContinuationsCount { get; set; }

        private int AmendedAndAssignedCount { get; set; }
    }
}