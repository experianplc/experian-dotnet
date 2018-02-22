namespace Experian.Api.Client.Bis
{
    public class JudgmentDetailResult
    {
        public string DateFiled { get; set; }

        public string LegalType { get; set; }

        public string LegalAction { get; set; }

        public string DocumentNumber { get; set; }

        public string FilingLocation { get; set; }

        public int LiabilityAmount { get; set; }

        public string PlaintiffName { get; set; }
    }
}