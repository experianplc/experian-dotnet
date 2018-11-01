namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The phone enrich v0 request.
    /// </summary>
    [DataContract]
    public class PhoneEnrichV0Request
    {
        /// <summary>
        /// The phone number submitted to be validated.
        /// </summary>
        /// <value>The phone number submitted to be validated.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        /// <summary>
        /// The country calling code for the phone number.
        /// </summary>
        /// <value>The country calling code for the phone number.</value>
        [DataMember(Name="country_code_number", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "country_code_number")]
        public int? CountryCodeNumber { get; set; }

        /// <summary>
        /// The dataset and specific attributes to be returned.
        /// </summary>
        /// <value>The dataset and specific attributes to be returned.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "attributes")]
        public PhoneEnrichV0DatasetAttributes Attributes { get; set; }
    }
}
