namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Enrichment data to be returned, based on the Australian Person dataset.
    /// </summary>
    [DataContract]
    public class PhoneEnrichV0DatasetAusCVPerson
    {
        /// <summary>
        /// Unique Experian-assigned consumer identifier.
        /// </summary>
        /// <value>Unique Experian-assigned consumer identifier.</value>
        [DataMember(Name="pin", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "pin")]
        public string Pin { get; set; }

        /// <summary>
        /// Enrichment data covering the consumer's gender.
        /// </summary>
        /// <value>Enrichment data covering the consumer's gender.</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }
    }
}
