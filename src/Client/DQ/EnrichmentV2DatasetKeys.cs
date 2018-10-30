namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Keys to search certain datasets.
    /// </summary>
    [DataContract]
  public class EnrichmentV2DatasetKeys
    {
    /// <summary>
    /// A unique Experian person identifier.
    /// </summary>
    /// <value>A unique Experian person identifier.</value>
    [DataMember(Name="pin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pin")]
    public string Pin { get; set; }

    /// <summary>
    /// Email Address.
    /// </summary>
    /// <value>Email Address.</value>
    [DataMember(Name="email_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Mobile Number.
    /// </summary>
    /// <value>Mobile Number.</value>
    [DataMember(Name="mobile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobile")]
    public string Mobile { get; set; }

    /// <summary>
    /// A unique identifier allocated to each address maintained in Australia Post's National Address File.
    /// </summary>
    /// <value>A unique identifier allocated to each address maintained in Australia Post's National Address File.</value>
    [DataMember(Name="dpid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dpid")]
    public string Dpid { get; set; }

    /// <summary>
    /// The persistent identifier of the address.             This is a unique 14-character alphanumeric identifier of the address record; for example,             GANSW716798454”. An additional mail_suppression attribute will be returned if the address             is suppressed and should not be contacted.
    /// </summary>
    /// <value>The persistent identifier of the address.             This is a unique 14-character alphanumeric identifier of the address record; for example,             GANSW716798454”. An additional mail_suppression attribute will be returned if the address             is suppressed and should not be contacted.</value>
    [DataMember(Name="gnaf_pid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gnaf_pid")]
    public string GnafPid { get; set; }

    /// <summary>
    /// A unique Experian household identifier.
    /// </summary>
    /// <value>A unique Experian household identifier.</value>
    [DataMember(Name="hin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hin")]
    public string Hin { get; set; }

    /// <summary>
    /// The postal code of the address.
    /// </summary>
    /// <value>The postal code of the address.</value>
    [DataMember(Name="postcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postcode")]
    public string Postcode { get; set; }
}
}
