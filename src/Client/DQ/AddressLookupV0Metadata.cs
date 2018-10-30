namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Metadata containing additional dataset specific values where relevant.
    /// </summary>
    [DataContract]
    public class AddressLookupV0Metadata
    {
        /// <summary>
        /// The specific identifier value related to the attribute.
        /// </summary>
        /// <value>The specific identifier value related to the attribute.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The description value related to the attribute.
        /// </summary>
        /// <value>The description value related to the attribute.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
