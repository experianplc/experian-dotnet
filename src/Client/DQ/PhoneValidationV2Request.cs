namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The phone validation v2 request.
    /// </summary>
    [DataContract]
    public class PhoneValidationV2Request
    {
        /// <summary>
        /// The phone number of the person who originates the call.
        /// </summary>
        /// <value>The phone number of the person who originates the call.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        /// <summary>
        /// The country code number of the phone number.
        /// </summary>
        /// <value>The country code number of the phone number.</value>
        [DataMember(Name="country_code_number", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "country_code_number")]
        public string CountryCodeNumber { get; set; }
    }
}
