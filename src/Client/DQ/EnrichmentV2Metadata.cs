namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Metadata containing additional dataset specific values where relevant.
    /// </summary>
    [DataContract]
  public class EnrichmentV2Metadata
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
    /// The message details.
    /// </summary>
    /// <value>The message details.</value>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public string Details { get; set; }

    /// <summary>
    /// The dataset name and related parameters.
    /// </summary>
    /// <value>The dataset name and related parameters.</value>
    [DataMember(Name="datasets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datasets")]
    public EnrichmentV2MetadataDatasets Datasets { get; set; }
}
}
