namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Enrichment data to be returned, based on the Reverse Append dataset.
    /// </summary>
    [DataContract]
    public class PhoneEnrichV0DatasetReverse
    {
        /// <summary>
        /// The type of phone number.
        /// </summary>
        /// <value>The type of phone number.</value>
        [DataMember(Name="phone_account_type", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "phone_account_type")]
        public string PhoneAccountType { get; set; }

        /// <summary>
        /// Enrichment data covering details related to the consumer.
        /// </summary>
        /// <value>Enrichment data covering details related to the consumer.</value>
        [DataMember(Name="person", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "person")]
        public PhoneEnrichV0Person Person { get; set; }

        /// <summary>
        /// The type of phone number.
        /// </summary>
        /// <value>The type of phone number.</value>
        [DataMember(Name="phone_type", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "phone_type")]
        public string PhoneType { get; set; }

        /// <summary>
        /// The match level of the address that indicates the success, such as Full Address.
        /// </summary>
        /// <value>The match level of the address that indicates the success, such as Full Address.</value>
        [DataMember(Name="address_integrity", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "address_integrity")]
        public string AddressIntegrity { get; set; }

        /// <summary>
        /// The address components to be validated, such as line1, line2, line3, locality, province, postal_code, country.
        /// </summary>
        /// <value>The address components to be validated, such as line1, line2, line3, locality, province, postal_code, country.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "address")]
        public PhoneEnrichV0Address Address { get; set; }
    }
}
