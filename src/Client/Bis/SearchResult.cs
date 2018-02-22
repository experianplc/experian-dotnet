namespace Experian.Api.Client.Bis
{
    public sealed class SearchResult
    {
        public string Bin { get; set; }

        public float ReliabilityCode { get; set; }

        public string BusinessName { get; set; }

        public string Phone { get; set; }

        public AddressResult Address { get; set; }

        public int NumberOfTradelines { get; set; }

        public bool FinancialStatementIndicator { get; set; }

        public bool KeyFactsIndicator { get; set; }

        public bool InquiryIndicator { get; set; }

        public bool BankDataIndicator { get; set; }

        public bool GovernmentDataIndicator { get; set; }

        public bool ExecutiveSummaryIndicator { get; set; }

        public bool UccIndicator { get; set; }

        public MatchingNameAndAddress MatchingNameAndAddress { get; set; }

    ////  public string Comments { get; set; }

        public BusinessGeocodeResult BusinessGeocode { get; set; }
    }
}
