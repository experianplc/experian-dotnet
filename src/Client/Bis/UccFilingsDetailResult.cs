namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;

    public sealed class UccFilingsDetailResult
    {
        public string DateFiled { get; set; }

        public string LegalType { get; set; }

        public string LegalAction { get; set; }

        public string DocumentNumber { get; set; }

        public List<CollateralCodesResult> CollateralCodes { get; set; }

        public string FilingLocation { get; set; }

        public string SecuredParty { get; set; }

        public string Assignee { get; set; }
    }
}
