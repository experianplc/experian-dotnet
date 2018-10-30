namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Details about the geographic location, such as latitude and longitude.
    /// </summary>
    [DataContract]
    public class AddressEnrichV0MetadataGeo
    {
        /// <summary>
        /// The longitute of the address.
        /// </summary>
        /// <value>The longitute of the address.</value>
        [DataMember(Name="lat", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "lat")]
        public DatasetMetadata Lat { get; set; }

        /// <summary>
        /// The longitute of the address.
        /// </summary>
        /// <value>The longitute of the address.</value>
        [DataMember(Name="lon", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "lon")]
        public DatasetMetadata Lon { get; set; }
    }
}
