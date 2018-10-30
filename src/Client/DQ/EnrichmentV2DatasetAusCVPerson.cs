namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Enrichment data to be returned, based on the Australian Person dataset.
    /// </summary>
    [DataContract]
    public class EnrichmentV2DatasetAusCVPerson
    {
        /// <summary>
        /// A unique Experian person identifier.
        /// </summary>
        /// <value>A unique Experian person identifier.</value>
        [DataMember(Name="pin", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "pin")]
        public string Pin { get; set; }

        /// <summary>
        /// Consumer's gender.
        /// </summary>
        /// <value>Consumer's gender.</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// A unique Experian household identifier.
        /// </summary>
        /// <value>A unique Experian household identifier.</value>
        [DataMember(Name="hin", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "hin")]
        public string Hin { get; set; }

        /// <summary>
        /// Linkage postal code.
        /// </summary>
        /// <value>Linkage postal code.</value>
        [DataMember(Name="linkage_postcode", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "linkage_postcode")]
        public string LinkagePostcode { get; set; }
    }
}
