namespace Experian.Api.Client.Bis
{
    using System;
    using Newtonsoft.Json;

    public sealed class ReverseAddressesRequest : BisRequest
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

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
