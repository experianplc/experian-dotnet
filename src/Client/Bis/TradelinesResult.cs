namespace Experian.Api.Client.Bis
{
public class TradelinesResult
{
    public int TradelineCount { get; set; }

    // Server API can return this value as null.
    public int? CurrentDbt { get; set; }

    public TotalHighCreditAmountResult TotalHighCreditAmount { get; set; }

    public TotalAccountBalanceResult TotalAccountBalance { get; set; }

    public int CurrentPercentage { get; set; }

    public int Dbt30 { get; set; }

    public int Dbt60 { get; set; }

    public int Dbt90 { get; set; }

    public int Dbt91Plus { get; set; }
}
}
