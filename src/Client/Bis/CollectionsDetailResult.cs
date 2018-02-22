namespace Experian.Api.Client.Bis
{
    public sealed class CollectionsDetailResult
    {
        public string AccountStatus { get; set; }

        public string DatePlacedForCollection { get; set; }

        public string DateClosed { get; set; }

        public int AmountPlacedForCollection { get; set; }

        public int AmountPaid { get; set; }

        public CollectionAgencyInfoResult CollectionAgencyInfo { get; set; }
    }
}