namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Details about the result. Includes the validated data and its confidence level.
    /// </summary>
    [DataContract]
    public class AddressFormatV0Result
    {
        /// <summary>
        /// The address components to be validated, such as line1, line2, line3, locality, province, postal_code, country.
        /// </summary>
        /// <value>The address components to be validated, such as line1, line2, line3, locality, province, postal_code, country.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "address")]
        public AddressFormatV0Address Address { get; set; }

        /// <summary>
        /// Details of the individual components that make up the address.
        /// </summary>
        /// <value>Details of the individual components that make up the address.</value>
        [DataMember(Name="components", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "components")]
        public AddressFormatV0Components Components { get; set; }
    }
}
