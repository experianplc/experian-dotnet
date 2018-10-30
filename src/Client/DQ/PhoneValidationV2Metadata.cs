namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Metadata containing additional dataset specific values where relevant.
    /// </summary>
    [DataContract]
    public class PhoneValidationV2Metadata
        {
        /// <summary>
        /// The request response code.
        /// </summary>
        /// <value>The request response code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// The request response message.
        /// </summary>
        /// <value>The request response message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// The additional phone details.
        /// </summary>
        /// <value>The additional phone details.</value>
        [DataMember(Name="phone_detail", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "phone_detail")]
        public PhoneValidationV2AdditionalPhoneInfo PhoneDetail { get; set; }
    }
}
