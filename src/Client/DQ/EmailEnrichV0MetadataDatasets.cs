namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The dataset name and related parameters.
    /// </summary>
    [DataContract]
  public class EmailEnrichV0MetadataDatasets
    {
    /// <summary>
    /// Enrichment metadata, based on the Australian Person dataset.
    /// </summary>
    /// <value>Enrichment metadata, based on the Australian Person dataset.</value>
    [DataMember(Name="AUS_CV_Person", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Person")]
    public EmailEnrichV0AusCVPersonMetadata AUSCVPerson { get; set; }
}
}
