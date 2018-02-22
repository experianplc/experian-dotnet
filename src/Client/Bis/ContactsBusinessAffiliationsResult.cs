namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;

    public sealed class ContactsBusinessAffiliationsResult
    {
        public string Bin { get; set; }

        public string BusinessName { get; set; }

        public BusinessContactsAddressResult BusinessContactsAddress { get; set; }

        ////  public ContactsAndTitlesResult ContactsAndTitles { get; set; }
        public List<ContactsAndTitlesResult> ContactsAndTitles { get; set; }
    }
}
