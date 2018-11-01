namespace Experian.Api.Client.DQ
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The dataset and specific attributes to be returned.
    /// </summary>
    [DataContract]
  public class EnrichmentV2DatasetAttributes
    {
    /// <summary>
    /// Australian ConsumerView Person Dataset Attributes.
    /// </summary>
    /// <value>Australian ConsumerView Person Dataset Attributes.</value>
    [DataMember(Name="AUS_CV_Person", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Person")]
    public List<string> AUSCVPerson { get; set; }

    /// <summary>
    /// Enrichment data to be returned, based on the Australian Household dataset.
    /// </summary>
    /// <value>Enrichment data to be returned, based on the Australian Household dataset.</value>
    [DataMember(Name="AUS_CV_Household", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Household")]
    public List<string> AUSCVHousehold { get; set; }

    /// <summary>
    /// Australian ConsumerView Postcode Dataset Attributes.
    /// </summary>
    /// <value>Australian ConsumerView Postcode Dataset Attributes.</value>
    [DataMember(Name="AUS_CV_Postcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Postcode")]
    public List<string> AUSCVPostcode { get; set; }
}
}
