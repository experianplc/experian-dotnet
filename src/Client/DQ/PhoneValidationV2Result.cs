namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Details about the result. Includes the validated data and its confidence level.
    /// </summary>
    [DataContract]
    public class PhoneValidationV2Result
    {
        /// <summary>
        /// The phone number.
        /// </summary>
        /// <value>The phone number.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        /// <summary>
        /// The type of the submitted phone number.
        /// </summary>
        /// <value>The type of the submitted phone number.</value>
        [DataMember(Name="phoneType", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "phoneType")]
        public string PhoneType { get; set; }

        /// <summary>
        /// The name of the country relating to the phone number.
        /// </summary>
        /// <value>The name of the country relating to the phone number.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// The phone number validation confidence.
        /// </summary>
        /// <value>The phone number validation confidence.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "confidence")]
        public string Confidence { get; set; }
    }
}
