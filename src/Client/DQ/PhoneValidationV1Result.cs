namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Details about the result. Includes the validated data and its confidence level.
    /// </summary>
    [DataContract]
    public class PhoneValidationV1Result
    {
        /// <summary>
        /// The status code of the submitted phone.
        /// </summary>
        /// <value>The status code of the submitted phone.</value>
        [DataMember(Name="ResultCode", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "ResultCode")]
        public string ResultCode { get; set; }

        /// <summary>
        /// The Experian.Hub.RealTimeHubService.Models.V1.Phone.PhoneValidationV1Result.AdditionalPhoneInfo.
        /// </summary>
        /// <value>The Experian.Hub.RealTimeHubService.Models.V1.Phone.PhoneValidationV1Result.AdditionalPhoneInfo.</value>
        [DataMember(Name="AdditionalPhoneInfo", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "AdditionalPhoneInfo")]
        public PhoneValidationV1AdditionalPhoneInfo AdditionalPhoneInfo { get; set; }

        /// <summary>
        /// The phone number supplied.
        /// </summary>
        /// <value>The phone number supplied.</value>
        [DataMember(Name="Number", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "Number")]
        public string Number { get; set; }

        /// <summary>
        /// The type of the submitted phone number.
        /// </summary>
        /// <value>The type of the submitted phone number.</value>
        [DataMember(Name="PhoneType", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "PhoneType")]
        public string PhoneType { get; set; }

        /// <summary>
        /// The description of the ResultCode.
        /// </summary>
        /// <value>The description of the ResultCode.</value>
        [DataMember(Name="Certainty", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "Certainty")]
        public string Certainty { get; set; }
    }
}
