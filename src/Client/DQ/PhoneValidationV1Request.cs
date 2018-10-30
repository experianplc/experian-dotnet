namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The phone validation v1 request.
    /// </summary>
    [DataContract]
    public class PhoneValidationV1Request
    {
        /// <summary>
        /// The phone number of the person who originates the call.
        /// </summary>
        /// <value>The phone number of the person who originates the call.</value>
        [DataMember(Name="Number", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "Number")]
        public string Number { get; set; }
    }
}
