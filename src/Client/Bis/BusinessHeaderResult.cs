namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;

    public sealed class BusinessHeaderResult
    {
        public string Bin { get; set; }

        public string BusinessName { get; set; }

        public AddressResult Address { get; set; }

        public string Phone { get; set; }

        public string TaxId { get; set; }

        public string WebsiteUrl { get; set; }

        public string LegalBusinessName { get; set; }

        public List<string> DbaNames { get; set; }

        public bool CustomerDisputeIndicator { get; set; }
    }
}
