namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;

    public sealed class ScoresResponse : BisResponse
    {
        public List<ScoresResult> Results { get; set; }
    }
}