namespace Experian.Api.Client.Bis
{
public sealed class CorporateLinkageFullResult : CorporateLinkagePartialResult
{
    public string UltimateBin { get; set; }

    public string ParentBin { get; set; }

    public bool UltimateParentIndicator { get; set; }

    public bool ParentIndicator { get; set; }

    public bool SubsidiaryIndicator { get; set; }

    public int LinkageLevel { get; set; }

    public bool BranchIndicator { get; set; }

    public bool ActivityIndicator { get; set; }

    public string CommercialRiskClass { get; set; }
}
}
