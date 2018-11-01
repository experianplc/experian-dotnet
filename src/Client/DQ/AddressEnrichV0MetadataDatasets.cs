namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The dataset name and related parameters.
    /// </summary>
    [DataContract]
    public class AddressEnrichV0MetadataDatasets
    {
        /// <summary>
        /// The returned Enrichment data, based on the Australian Household dataset.
        /// </summary>
        /// <value>The returned Enrichment data, based on the Australian Household dataset.</value>
        [DataMember(Name="AUC_CV_Household", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "AUC_CV_Household")]
        public AddressEnrichV0MetadataAusCVHousehold AUCCVHousehold { get; set; }

        /// <summary>
        /// Details about the geographic location, such as latitude and longitude.
        /// </summary>
        /// <value>Details about the geographic location, such as latitude and longitude.</value>
        [DataMember(Name="Geo", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "Geo")]
        public AddressEnrichV0MetadataGeo Geo { get; set; }
    }
}
