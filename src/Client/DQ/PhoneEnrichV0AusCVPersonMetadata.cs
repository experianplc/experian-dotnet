namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Enrichment metadata, based on the Australian Person dataset.
    /// </summary>
    [DataContract]
    public class PhoneEnrichV0AusCVPersonMetadata
    {
        /// <summary>
        /// A unique Experian person identifier.
        /// </summary>
        /// <value>A unique Experian person identifier.</value>
        [DataMember(Name="pin", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "pin")]
        public DatasetMetadata Pin { get; set; }

        /// <summary>
        /// Consumer's gender.
        /// </summary>
        /// <value>Consumer's gender.</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "gender")]
        public DatasetMetadata Gender { get; set; }
    }
}
