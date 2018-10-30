namespace Experian.Api.Client.Bis
{
    using System;
    using Newtonsoft.Json;

    public sealed class ReversePhonesRequest : BisRequest
    {
        public string Phone { get; set; }

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
