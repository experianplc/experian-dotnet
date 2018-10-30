namespace Experian.Api.Client.DQ
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The dataset and specific attributes to be returned.
    /// </summary>
    [DataContract]
    public class AddressEnrichV0DatasetAttributes
    {
        /// <summary>
        /// Details about the geographic location, such as latitude and longitude.
        /// </summary>
        /// <value>Details about the geographic location, such as latitude and longitude.</value>
        [DataMember(Name="Geo", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "Geo")]
        public List<string> Geo { get; set; }

        /// <summary>
        /// Enrichment data to be returned, based on the Australian Household dataset.
        /// </summary>
        /// <value>Enrichment data to be returned, based on the Australian Household dataset.</value>
        [DataMember(Name="AUS_CV_Household", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "AUS_CV_Household")]
        public List<string> AUSCVHousehold { get; set; }
    }
}
