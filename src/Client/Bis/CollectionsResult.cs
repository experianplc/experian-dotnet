namespace Experian.Api.Client.Bis
{
using System;
using System.Collections.Generic;

public sealed class CollectionsResult
{
    public BusinessHeaderResult BusinessHeader { get; set; }

    public CollectionsSummaryResult CollectionsSummary { get; set; }

    public List<CollectionsDetailResult> CollectionsDetail { get; set; }

    public bool CollectionsIndicator { get; set; }
}
}
