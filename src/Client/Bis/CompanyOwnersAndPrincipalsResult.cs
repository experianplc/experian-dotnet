namespace Experian.Api.Client.Bis
{
    public sealed class CompanyOwnersAndPrincipalsResult
    {
        public string DateReported { get; set; }

        public bool CurrentOwnerIndicator { get; set; }

        public string BusinessName { get; set; }

        public string TaxId { get; set; }

        public TaxIdTypeResult TaxIdType { get; set; }

        public string InternetDomain { get; set; }

        public bool OwnerIsGuarantorIndicator { get; set; }

        public BusinessContactsAddressResult BusinessContactsAddress { get; set; }

        public string Phone { get; set; }

        public int PercentOfFinancialObligation { get; set; }

        public bool NameAddressChangeIndicator { get; set; }
    }
}
