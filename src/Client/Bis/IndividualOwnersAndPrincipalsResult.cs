namespace Experian.Api.Client.Bis
{
    public sealed class IndividualOwnersAndPrincipalsResult : AddressResult
    {
        public string DateReported { get; set; }

        public bool CurrentOwnerIndicator { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string GenerationCode { get; set; }

        public string EmailAddress { get; set; }

        public bool OwnerIsGuarantorIndicator { get; set; }

        public bool NameAddressChangeIndicator { get; set; }

        public int PercentOfFinancialObligation { get; set; }

     //// public BusinessContactsAddressResult BusinessContactsAddress { get; set; }

        public AddressResult AddressResult { get; set; }
    }
}
