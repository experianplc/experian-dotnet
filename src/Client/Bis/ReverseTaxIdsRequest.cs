namespace Experian.Api.Client.Bis
{
    using System;
    using Newtonsoft.Json;

    public sealed class ReverseTaxIdsRequest : BisRequest
    {
        public string TaxId { get; set; }

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
