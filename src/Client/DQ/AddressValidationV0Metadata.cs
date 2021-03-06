namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Metadata containing additional dataset specific values where relevant.
    /// </summary>
    [DataContract]
  public class AddressValidationV0Metadata
    {
    /// <summary>
    /// The specific identifier value related to the attribute.
    /// </summary>
    /// <value>The specific identifier value related to the attribute.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// The description value related to the attribute.
    /// </summary>
    /// <value>The description value related to the attribute.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Metadata for USA addresses only. USPS deliverable and historical information.
    /// </summary>
    /// <value>Metadata for USA addresses only. USPS deliverable and historical information.</value>
    [DataMember(Name="address_dpv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_dpv")]
    public AddressValidationV0DPV AddressDpv { get; set; }

    /// <summary>
    /// Breakdown of each compenent and its match status.
    /// </summary>
    /// <value>Breakdown of each compenent and its match status.</value>
    [DataMember(Name="address_quality", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_quality")]
    public AddressValidationV0Quality AddressQuality { get; set; }
}
}
