namespace Experian.Api.Client.DQ
{
    using System.Collections.Generic;

    public class DataQualityHeaders : IHeader
    {
        public const string AddMetadatKey = "Add-Metadata";

        public const string ReferenceIdKey = "Reference-Id";

        public DataQualityHeaders(string referenceId = null, bool addMetadata = false)
        {
            this.ReferenceId = referenceId;
            this.AddMetadata = addMetadata;
        }

        public bool AddMetadata { get; }

        public string ReferenceId { get; }

        public Dictionary<string, string> Headers { get; } = new Dictionary<string, string>();
    }
}
