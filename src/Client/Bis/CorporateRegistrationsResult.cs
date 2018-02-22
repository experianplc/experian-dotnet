namespace Experian.Api.Client.Bis
{
    public sealed class CorporateRegistrationsResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public string LegalName { get; set; }

        public string StateOfOrigin { get; set; }

        public string OriginalFilingDate { get; set; }

        public string RecentFilingDate { get; set; }

        public string IncorporatedDate { get; set; }

        public string BusinessType { get; set; }

        public string StatusFlag { get; set; }

        public string StatusDescription { get; set; }

        public string StatusDescriptionDetail { get; set; }

        public string ProfitFlag { get; set; }

        public string CharterNumber { get; set; }

        // Server API can return this value as null.
        public int? ExistenceTermYears { get; set; }

        public string ExistenceTermDate { get; set; }

        public string FederalTaxId { get; set; }

        public string StateTaxId { get; set; }

        public string DomesticForeignIndicator { get; set; }

        public string AgentName { get; set; }

        public AgentAddressResult AgentAddress { get; set; }

        public bool CorporateRegistrationIndicator { get; set; }
    }
}
