namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Details of the individual components that make up the address.
    /// </summary>
    [DataContract]
    public class AddressFormatV0Components
    {
        /// <summary>
        /// The 3-character ISO country code.
        /// </summary>
        /// <value>The 3-character ISO country code.</value>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The postal or ZIP code of the address.
        /// </summary>
        /// <value>The postal or ZIP code of the address.</value>
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
