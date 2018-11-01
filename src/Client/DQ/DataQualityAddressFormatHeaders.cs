namespace Experian.Api.Client.DQ
{
    public sealed class DataQualityAddressFormatHeaders : DataQualityHeaders
    {
        public const string LayoutKey = "Layout";

        public DataQualityAddressFormatHeaders(string referenceId = null, bool addMetadata = false, string layout = null)
            : base(referenceId, addMetadata)
        {
            this.Layout = layout;
        }

        public string Layout { get; }
    }
}
