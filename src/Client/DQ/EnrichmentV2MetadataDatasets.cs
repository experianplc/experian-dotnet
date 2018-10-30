namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The dataset name and related parameters.
    /// </summary>
    [DataContract]
  public class EnrichmentV2MetadataDatasets
    {
    /// <summary>
    /// The ConsumerView Australia - Household data.
    /// </summary>
    /// <value>The ConsumerView Australia - Household data.</value>
    [DataMember(Name="AUS_CV_Household", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Household")]
    public EnrichmentV2AusCVHouseholdMetadata AUSCVHousehold { get; set; }

    /// <summary>
    /// The ConsumerView Australia - Person data.
    /// </summary>
    /// <value>The ConsumerView Australia - Person data.</value>
    [DataMember(Name="AUS_CV_Person", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Person")]
    public EnrichmentV2AusCVPersonMetadata AUSCVPerson { get; set; }

    /// <summary>
    /// The ConsumerView Australia - Postcode data.
    /// </summary>
    /// <value>The ConsumerView Australia - Postcode data.</value>
    [DataMember(Name="AUS_CV_Postcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Postcode")]
    public EnrichmentV2AusCVPostcodeMetadata AUSCVPostcode { get; set; }
}
}
