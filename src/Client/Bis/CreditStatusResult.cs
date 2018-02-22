namespace Experian.Api.Client.Bis
{
    public sealed class CreditStatusResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public int CombinedTradelineCount { get; set; }

        public int CombinedAccountBalance { get; set; }

        public int CurrentDbt { get; set; }

        public int CombinedRecentHighCreditAmount { get; set; }

        public int YearsOnFile { get; set; }

        public int InquiryCount { get; set; }
}
}
