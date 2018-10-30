namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;

    public sealed class CorporateLinkageResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public List<CorporateLinkagePartialResult> CorporateLinkagePartial { get; set; }

        public List<CorporateLinkageFullResult> CorporateLinkageFull { get; set; }

        public bool CorporateLinkageIndicator { get; set; }
    }
}
