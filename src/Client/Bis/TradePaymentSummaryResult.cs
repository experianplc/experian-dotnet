namespace Experian.Api.Client.Bis
{
public sealed class TradePaymentSummaryResult
{
    public int CurrentDbt { get; set; }

    public int MonthlyAverageDbt { get; set; }

    public int HighestDbt6Months { get; set; }

    public int HighestDbt5Quarters { get; set; }

    public int AllTradelineCount { get; set; }

    public int AllTradelineBalance { get; set; }

    public int CurrentTradelineCount { get; set; }

    public int CurrentAccountBalance { get; set; }

    public int MedianCreditAmountExtended { get; set; }

    public int SingleHighCredit { get; set; }
}
}
