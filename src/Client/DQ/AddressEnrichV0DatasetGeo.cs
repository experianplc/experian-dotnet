namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Details about the geographic location, such as latitude and longitude.
    /// </summary>
    [DataContract]
    public class AddressEnrichV0DatasetGeo
    {
        /// <summary>
        /// The longitute of the address.
        /// </summary>
        /// <value>The longitute of the address.</value>
        [DataMember(Name="lat", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "lat")]
        public string Lat { get; set; }

        /// <summary>
        /// The latitude of the address.
        /// </summary>
        /// <value>The latitude of the address.</value>
        [DataMember(Name="lon", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "lon")]
        public string Lon { get; set; }
    }
}
