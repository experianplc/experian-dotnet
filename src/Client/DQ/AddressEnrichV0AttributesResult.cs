namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The dataset and specific attributes to be returned.
    /// </summary>
    [DataContract]
    public class AddressEnrichV0AttributesResult
    {
        /// <summary>
        /// Details about the geographic location, such as latitude and longitude.
        /// </summary>
        /// <value>Details about the geographic location, such as latitude and longitude.</value>
        [DataMember(Name="Geo", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "Geo")]
        public AddressEnrichV0DatasetGeo Geo { get; set; }

        /// <summary>
        /// Enrichment data to be returned, based on the Australian Household dataset.
        /// </summary>
        /// <value>Enrichment data to be returned, based on the Australian Household dataset.</value>
        [DataMember(Name="AUS_CV_Household", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "AUS_CV_Household")]
        public AddressEnrichV0DatasetAusCVHousehold AUSCVHousehold { get; set; }
    }
}
