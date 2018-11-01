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
  public class EmailEnrichV0DatasetAttributes
    {
    /// <summary>
    /// Enrichment data to be returned, based on the Australian Person dataset.
    /// </summary>
    /// <value>Enrichment data to be returned, based on the Australian Person dataset.</value>
    [DataMember(Name="AUS_CV_Person", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AUS_CV_Person")]
    public List<string> AUSCVPerson { get; set; }
}
}
