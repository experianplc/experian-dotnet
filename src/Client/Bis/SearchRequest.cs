namespace Experian.Api.Client.Bis
{
    using System;
    using Newtonsoft.Json;

    public sealed class SearchRequest : BisRequest
    {
        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Street { get; set; }

        public string Zip { get; set; }

        public string Phone { get; set; }

        public string TaxId { get; set; }

        public string Comments { get; set; }

        public bool Geo { get; set; }

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
