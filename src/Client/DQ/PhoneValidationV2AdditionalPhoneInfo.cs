namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The phone validation v2 additional phone information.
    /// </summary>
    [DataContract]
    public class PhoneValidationV2AdditionalPhoneInfo
    {
        /// <summary>
        /// The verified number in international format without the leading \"+\".
        /// </summary>
        /// <value>The verified number in international format without the leading \"+\".</value>
        [DataMember(Name="validatedPhoneNumber", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "validatedPhoneNumber")]
        public string ValidatedPhoneNumber { get; set; }

        /// <summary>
        /// The name of the country relating to the phone number.
        /// </summary>
        /// <value>The name of the country relating to the phone number.</value>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "countryName")]
        public string CountryName { get; set; }

        /// <summary>
        /// The home country relating to the phone number.
        /// </summary>
        /// <value>The home country relating to the phone number.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The company name of the MSISDN Operator.
        /// </summary>
        /// <value>The company name of the MSISDN Operator.</value>
        [DataMember(Name="operatorName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "operatorName")]
        public string OperatorName { get; set; }

        /// <summary>
        /// The operator from which the mobile number is ported.
        /// </summary>
        /// <value>The operator from which the mobile number is ported.</value>
        [DataMember(Name="portedOperatorName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "portedOperatorName")]
        public string PortedOperatorName { get; set; }

        /// <summary>
        /// The name of the country from which the mobile number is ported.
        /// </summary>
        /// <value>The name of the country from which the mobile number is ported.</value>
        [DataMember(Name="portedCountryName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "portedCountryName")]
        public string PortedCountryName { get; set; }

        /// <summary>
        /// The home country code from which the mobile number is ported.
        /// </summary>
        /// <value>The home country code from which the mobile number is ported.</value>
        [DataMember(Name="portedCountryCode", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "portedCountryCode")]
        public string PortedCountryCode { get; set; }

        /// <summary>
        /// Indicates whether the number is currently outside of the country where it is registered.
        /// </summary>
        /// <value>Indicates whether the number is currently outside of the country where it is registered.</value>
        [DataMember(Name="isRoaming", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "isRoaming")]
        public string IsRoaming { get; set; }

        /// <summary>
        /// The network name of the Mobile Switching Centre that the number is currently connected to.
        /// </summary>
        /// <value>The network name of the Mobile Switching Centre that the number is currently connected to.</value>
        [DataMember(Name="roamingNetworkName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "roamingNetworkName")]
        public string RoamingNetworkName { get; set; }

        /// <summary>
        /// The prefix of the Mobile Switching Centre the number is currently connected to.
        /// </summary>
        /// <value>The prefix of the Mobile Switching Centre the number is currently connected to.</value>
        [DataMember(Name="roamingNetworkPrefix", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "roamingNetworkPrefix")]
        public string RoamingNetworkPrefix { get; set; }

        /// <summary>
        /// The prefix of the country the number is currently located in.
        /// </summary>
        /// <value>The prefix of the country the number is currently located in.</value>
        [DataMember(Name="roamingCountryCode", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "roamingCountryCode")]
        public string RoamingCountryCode { get; set; }

        /// <summary>
        /// The mobile Country Code (MCC) and Mobile Network Code (MNC).
        /// </summary>
        /// <value>The mobile Country Code (MCC) and Mobile Network Code (MNC).</value>
        [DataMember(Name="mccmnc", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mccmnc")]
        public string Mccmnc { get; set; }
    }
}
