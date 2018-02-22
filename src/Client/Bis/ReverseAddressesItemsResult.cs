namespace Experian.Api.Client.Bis
{
    public sealed class ReverseAddressesItemsResult
    {
        public string SequenceNumber { get; set; }

        public string Bin { get; set; }

        public string BusinessName { get; set; }

        public AddressResult Address { get; set; }

        public string BinEstablishDate { get; set; }

        public string BinActivityCode { get; set; }

        public string BinDateLastReported { get; set; }
    }
}
