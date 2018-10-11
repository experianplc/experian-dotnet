namespace Experian.Api.Client.Bis
{
    using System;
    using Newtonsoft.Json;

    public sealed class ScoresAutoRequest : BisRequest
    {
        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Street { get; set; }

        public string Zip { get; set; }

        public string Phone { get; set; }

        public string TaxId { get; set; }

        public bool Geo { get; set; }

        public string Comments { get; set; }

        public string ModelCode { get; set; }

        public int MatchReliabilityCode { get; set; }

        public bool CommercialScore { get; set; }

        public bool FsrScore { get; set; }

        [JsonIgnore]
        public override string Bin
        {
            get
            {
                throw new NotSupportedException("Parameter not supported");
            }

            set
            {
                throw new NotSupportedException("Parameter not supported");
            }
        }
    }
}
