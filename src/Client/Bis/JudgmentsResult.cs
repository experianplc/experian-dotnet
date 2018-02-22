namespace Experian.Api.Client.Bis
{
using System;
using System.Collections.Generic;

public sealed class JudgmentsResult
{
    public BusinessHeaderResult BusinessHeader { get; set; }

    public JudgmentSummaryResult JudgmentSummary { get; set; }

    public List<JudgmentDetailResult> JudgmentDetail { get; set; }

    public bool JudgmentIndicator { get; set; }
}
}
