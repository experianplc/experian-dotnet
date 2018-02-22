namespace Experian.Api.Client.Bis
{
using System;
using System.Collections.Generic;

public sealed class BusinessContactsResult
{
    public BusinessHeaderResult BusinessHeader { get; set; }

    public List<IndividualOwnersAndPrincipalsResult> IndividualOwnersAndPrincipals { get; set; }

    public List<CompanyOwnersAndPrincipalsResult> CompanyOwnersAndPrincipals { get; set; }

    public List<ContactsAndTitlesResult> ContactsAndTitles { get; set; }

    public List<ContactsBusinessAffiliationsResult> ContactsBusinessAffiliations { get; set; }
}
}
