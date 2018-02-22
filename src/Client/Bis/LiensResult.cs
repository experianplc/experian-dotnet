namespace Experian.Api.Client.Bis
{
using System;
using System.Collections.Generic;

public sealed class LiensResult
{
    public BusinessHeaderResult BusinessHeader { get; set; }

    public LienSummaryResult LienSummary { get; set; }

    public List<LienDetailResult> LienDetail { get; set; }

    public bool LienIndicator { get; set; }
}
}
