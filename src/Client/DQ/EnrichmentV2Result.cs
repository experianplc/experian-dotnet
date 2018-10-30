namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Details about the result. Includes the enriched data.
    /// </summary>
    [DataContract]
  public class EnrichmentV2Result
    {
    /// <summary>
    /// The ConsumerView Australia - Household data.
    /// </summary>
    /// <value>The ConsumerView Australia - Household data.</value>
    [DataMember(Name="AUS_CV_Household", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Household")]
    public EnrichmentV2DatasetAusCVHousehold AUSCVHousehold { get; set; }

    /// <summary>
    /// The ConsumerView Australia - Person data.
    /// </summary>
    /// <value>The ConsumerView Australia - Person data.</value>
    [DataMember(Name="AUS_CV_Person", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Person")]
    public EnrichmentV2DatasetAusCVPerson AUSCVPerson { get; set; }

    /// <summary>
    /// The ConsumerView Australia - Postcode data.
    /// </summary>
    /// <value>The ConsumerView Australia - Postcode data.</value>
    [DataMember(Name="AUS_CV_Postcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Postcode")]
    public EnrichmentV2DatasetAusCVPostcode AUSCVPostcode { get; set; }
}
}
