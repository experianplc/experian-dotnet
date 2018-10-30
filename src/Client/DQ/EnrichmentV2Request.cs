namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The enrichment v2 request.
    /// </summary>
    [DataContract]
  public class EnrichmentV2Request
    {
    /// <summary>
    /// Keys to search certain datasets.
    /// </summary>
    /// <value>Keys to search certain datasets.</value>
    [DataMember(Name="keys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keys")]
    public EnrichmentV2DatasetKeys Keys { get; set; }

    /// <summary>
    /// The dataset and specific attributes to be returned.
    /// </summary>
    /// <value>The dataset and specific attributes to be returned.</value>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public EnrichmentV2DatasetAttributes Attributes { get; set; }
}
}
