namespace Experian.Api.Client.Bis
{
    using System.Collections.Generic;

    public sealed class ScoresReponse : BisResponse
    {
        public List<ScoresResult> Results { get; set; }
    }
}