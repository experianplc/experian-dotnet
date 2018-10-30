namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Metadata containing additional dataset specific values where relevant.
    /// </summary>
    [DataContract]
  public class EmailEnrichV0Metadata
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
    /// Additional information on the confidence level.
    /// </summary>
    /// <value>Additional information on the confidence level.</value>
    [DataMember(Name="email_verbose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_verbose")]
    public string EmailVerbose { get; set; }

    /// <summary>
    /// The dataset name and related parameters.
    /// </summary>
    /// <value>The dataset name and related parameters.</value>
    [DataMember(Name="datasets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datasets")]
    public EmailEnrichV0MetadataDatasets Datasets { get; set; }
}
}
