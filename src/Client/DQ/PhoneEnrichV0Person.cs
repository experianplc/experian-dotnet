namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Enrichment data covering details related to the consumer.
    /// </summary>
    [DataContract]
    public class PhoneEnrichV0Person
    {
        /// <summary>
        /// Enrichment data covering the business or consumer's name.
        /// </summary>
        /// <value>Enrichment data covering the business or consumer's name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Enrichment data covering the business or the consumer's first name.
        /// </summary>
        /// <value>Enrichment data covering the business or the consumer's first name.</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Enrichment data covering  the business or consumer's middle initial.
        /// </summary>
        /// <value>Enrichment data covering  the business or consumer's middle initial.</value>
        [DataMember(Name="middle_initial", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "middle_initial")]
        public string MiddleInitial { get; set; }

        /// <summary>
        /// Enrichment data covering the business or the consumer's last name.
        /// </summary>
        /// <value>Enrichment data covering the business or the consumer's last name.</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }
    }
}
