namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The address components to be validated, such as line1, line2, line3, locality, province, postal_code, country.
    /// </summary>
    [DataContract]
    public class AddressFormatV0Address
    {
        /// <summary>
        /// The first line of the address.
        /// </summary>
        /// <value>The first line of the address.</value>
        [DataMember(Name="line1", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        /// <value>The second line of the address.</value>
        [DataMember(Name="line2", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// The third line of the address.
        /// </summary>
        /// <value>The third line of the address.</value>
        [DataMember(Name="line3", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "line3")]
        public string Line3 { get; set; }

        /// <summary>
        /// The address locality or city.
        /// </summary>
        /// <value>The address locality or city.</value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "locality")]
        public string Locality { get; set; }

        /// <summary>
        /// The address province/state.
        /// </summary>
        /// <value>The address province/state.</value>
        [DataMember(Name="province", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "province")]
        public string Province { get; set; }

        /// <summary>
        /// The address postal code.
        /// </summary>
        /// <value>The address postal code.</value>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// The address country.
        /// </summary>
        /// <value>The address country.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
    }
}
