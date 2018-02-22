namespace Experian.Api.Client.Bis
{
using System;
    using System.Collections.Generic;

    public sealed class BankruptcyResult
{
    public bool BankruptcyIndicator { get; set; }

    public BusinessHeaderResult BusinessHeader { get; set; }

    public BankruptcySummaryResult BankruptcySummary { get; set; }

    public List<BakruptcyDetailResult> BankruptcyDetail { get; set; }
}
}
