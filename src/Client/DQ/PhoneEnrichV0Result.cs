namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Details about the result. Includes the validated data and its confidence level.
    /// </summary>
    [DataContract]
    public class PhoneEnrichV0Result
    {
        /// <summary>
        /// The phone number submitted to be validated.
        /// </summary>
        /// <value>The phone number submitted to be validated.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        /// <summary>
        /// The outcome (confidence level) of the validation search.
        /// </summary>
        /// <value>The outcome (confidence level) of the validation search.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "confidence")]
        public string Confidence { get; set; }

        /// <summary>
        /// The type of phone number.
        /// </summary>
        /// <value>The type of phone number.</value>
        [DataMember(Name="phone_type", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "phone_type")]
        public string PhoneType { get; set; }

        /// <summary>
        /// The 3-character ISO country code.
        /// </summary>
        /// <value>The 3-character ISO country code.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// The dataset and specific attributes to be returned.
        /// </summary>
        /// <value>The dataset and specific attributes to be returned.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "attributes")]
        public PhoneEnrichV0AttributesResult Attributes { get; set; }
    }
}
