namespace Experian.Api.Client.DQ
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Breakdown of each compenent and its match status.
    /// </summary>
    [DataContract]
    public class AddressEnrichV0Quality
    {
        /// <summary>
        /// The outcome (confidence level) of the validation search.
        /// </summary>
        /// <value>The outcome (confidence level) of the validation search.</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "confidence")]
        public string Confidence { get; set; }

        /// <summary>
        /// Address components that were matched.
        /// </summary>
        /// <value>Address components that were matched.</value>
        [DataMember(Name="matched", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "matched")]
        public List<string> Matched { get; set; }

        /// <summary>
        /// Address components that were accurate and did not need correction.
        /// </summary>
        /// <value>Address components that were accurate and did not need correction.</value>
        [DataMember(Name="retained", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "retained")]
        public List<string> Retained { get; set; }

        /// <summary>
        /// Address components that have been corrected.
        /// </summary>
        /// <value>Address components that have been corrected.</value>
        [DataMember(Name="corrected", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "corrected")]
        public List<string> Corrected { get; set; }

        /// <summary>
        /// Address components that are missing (could not be returned).
        /// </summary>
        /// <value>Address components that are missing (could not be returned).</value>
        [DataMember(Name="missing", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "missing")]
        public List<string> Missing { get; set; }
    }
}
