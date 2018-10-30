namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Additional phone information.
    /// </summary>
    [DataContract]
    public class PhoneValidationV1AdditionalPhoneInfo
    {
        /// <summary>
        /// The verified number in international format without the leading \"+\".
        /// </summary>
        /// <value>The verified number in international format without the leading \"+\".</value>
        [DataMember(Name="ValidatedPhoneNumber", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "ValidatedPhoneNumber")]
        public string ValidatedPhoneNumber { get; set; }

        /// <summary>
        /// The name of the country relating to the phone number.
        /// </summary>
        /// <value>The name of the country relating to the phone number.</value>
        [DataMember(Name="CountryName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "CountryName")]
        public string CountryName { get; set; }

        /// <summary>
        /// The home country relating to the phone number.
        /// </summary>
        /// <value>The home country relating to the phone number.</value>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "CountryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The company name of the MSISDN Operator.
        /// </summary>
        /// <value>The company name of the MSISDN Operator.</value>
        [DataMember(Name="OperatorName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "OperatorName")]
        public string OperatorName { get; set; }

        /// <summary>
        /// The operator from which the mobile number is ported.
        /// </summary>
        /// <value>The operator from which the mobile number is ported.</value>
        [DataMember(Name="PortedOperatorName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "PortedOperatorName")]
        public string PortedOperatorName { get; set; }

        /// <summary>
        /// The name of the country from which the mobile number is ported.
        /// </summary>
        /// <value>The name of the country from which the mobile number is ported.</value>
        [DataMember(Name="PortedCountryName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "PortedCountryName")]
        public string PortedCountryName { get; set; }

        /// <summary>
        /// The home country code from which the mobile number is ported.
        /// </summary>
        /// <value>The home country code from which the mobile number is ported.</value>
        [DataMember(Name="PortedCountryCode", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "PortedCountryCode")]
        public string PortedCountryCode { get; set; }

        /// <summary>
        /// Indicates whether the number is currently outside of the country where it is registered.
        /// </summary>
        /// <value>Indicates whether the number is currently outside of the country where it is registered.</value>
        [DataMember(Name="IsRoaming", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "IsRoaming")]
        public string IsRoaming { get; set; }

        /// <summary>
        /// Gets or sets the network name of the Mobile Switching Centre that the number is currently connected to.
        /// </summary>
        /// <value>Gets or sets the network name of the Mobile Switching Centre that the number is currently connected to.</value>
        [DataMember(Name="RoamingNetworkName", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "RoamingNetworkName")]
        public string RoamingNetworkName { get; set; }

        /// <summary>
        /// The prefix of the Mobile Switching Centre the number is currently connected to.
        /// </summary>
        /// <value>The prefix of the Mobile Switching Centre the number is currently connected to.</value>
        [DataMember(Name="RoamingNetworkPrefix", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "RoamingNetworkPrefix")]
        public string RoamingNetworkPrefix { get; set; }

        /// <summary>
        /// The prefix of the country the number is currently located in.
        /// </summary>
        /// <value>The prefix of the country the number is currently located in.</value>
        [DataMember(Name="RoamingCountryCode", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "RoamingCountryCode")]
        public string RoamingCountryCode { get; set; }

        /// <summary>
        /// The mobile Country Code (MCC) and Mobile Network Code (MNC).
        /// </summary>
        /// <value>The mobile Country Code (MCC) and Mobile Network Code (MNC).</value>
        [DataMember(Name="MCCMNC", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "MCCMNC")]
        public string MCCMNC { get; set; }
    }
}
