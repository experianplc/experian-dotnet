namespace Experian.Api.Client.DQ
{
    public sealed class DataQualityEnrichHeaders : DataQualityHeaders
    {
        public const string MatchRuleKey = "Match-Rule";

        public const string LinkageRuleKey = "Linkage-Rule";

        public const string LayoutKey = "Layout";

        public DataQualityEnrichHeaders(string referenceId = null, bool addMetadata = false, string matchRule = null, string linkageRule = null, string layout = null)
            : base(referenceId, addMetadata)
        {
            this.MatchRule = matchRule;
            this.LinkageRule = LinkageRule;
            this.Layout = layout;
        }

        public string MatchRule { get; }

        public string LinkageRule { get; }

        public string Layout { get; }
    }
}
