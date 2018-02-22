namespace Experian.Api.Client.Bis
{
public class CorporateLinkagePartialResult
{
    public string CorporateLinkageType { get; set; }

    public string Bin { get; set; }

    public string BusinessName { get; set; }

    public AddressCorporateLinkageResult Address { get; set; }

    public bool MatchingBusinessIndicator { get; set; }

    public bool ReturnLimitExceeded { get; set; }
}
}
