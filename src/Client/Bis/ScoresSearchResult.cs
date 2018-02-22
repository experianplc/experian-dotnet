namespace Experian.Api.Client.Bis
{
    using System;
    using System.Collections.Generic;

    public sealed class ScoresSearchResult
    {
        public BusinessHeaderResult BusinessHeader { get; set; }

        public CommercialScoreResult CommercialScore { get; set; }

        public List<CommercialScoreFactorsResult> CommercialScoreFactors { get; set; }

        public List<CommercialScoreTrendsResult> CommercialScoreTrends { get; set; }

        public FSRScoreResult FsrScore { get; set; }

        public List<FSRScoreFactorsResult> FsrScoreFactors { get; set; }

        public List<FSRScoreTrendsResult> FsrScoreTrends { get; set; }

        public List<SearchResult> ListOfSimilars { get; set; }
    }
}
