namespace Experian.Api.Client.Bis
{
    public sealed class LegalFilingsCollectionsSummaryResult
    {
        public int LegalCount { get; set; }

        public int LegalBalance { get; set; }

        public int DerogatoryLegalCount { get; set; }

        public bool BankruptcyIndicator { get; set; }

        public int BankruptcyCount { get; set; }

        public int LienCount { get; set; }

        public int LienBalance { get; set; }

        public int JudgmentCount { get; set; }

        public int JudgmentBalance { get; set; }

        public int UccFilingsCount { get; set; }

        public int UccDerogatoryCount { get; set; }

        public int CollectionCount { get; set; }

        public int CollectionBalance { get; set; }
    }
}
